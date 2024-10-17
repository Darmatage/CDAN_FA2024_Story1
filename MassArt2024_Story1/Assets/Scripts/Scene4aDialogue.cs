using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene4aDialogue : MonoBehaviour {
        // These are the script variables.
        // For more character images or buttons, duplicate the ArtChar ones listed here and renumber.
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name; //Player & Narrator
        public TMP_Text Char1speech;
        public TMP_Text Char2name; // Stranger
        public TMP_Text Char2speech;
        public TMP_Text Char3name; //This is reserved for nonstranger, nonplayer, and nonnarrator character
        public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //Stranger
        public GameObject ArtChar1b; //Stranger diff pose (change to 1b/1c/1d/etc for multiple poses in same scene)
        public GameObject ArtChar2; //NonStranger, same logic for multiple as above
        public GameObject ArtBG1; //Background, same logic for multiple as above
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Initial visibility settings. Any new images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             nextButton.SetActive(true);
        }

// Use the spacebar as a faster "Next" button:
        void Update(){        
             if (allowSpace == true){
                 if (Input.GetKeyDown("space")){
                      Next();
                 }
             }
        }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "The Stranger guides you on a path you don’t recognize. The recognizable architecture and familiar streets fade away the farther and farther you travel. Your beacon of home crumbling as you are taken away to who knows where.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Narration";
                Char1speech.text = "You start to follow train tracks away from civilization to a bridge. The stillness of the night being evidence that you are now truly alone with this stranger.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I have to thank you for showing me around. Even if it was against your will you did show me some cool spots like I asked.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==5){
                Char1name.text = "Narration";
                Char1speech.text = "The stranger steps closer";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6   ){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I’m a dead man walking, my life is over.";
                Char3name.text = "";
                Char3speech.text = "";

        }
       else if (primeInt == 7   ){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I’m a dead man walking, my life is over.";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I’m just tired. After everything I just don’t see a point anymore. I’ve seen what’s expected of me. I know they just want another cog in this fucked up machine.";
                Char3name.text = "";
                Char3speech.text = "";
        }

       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Everyone at each other’s throats, everyone taking their shit out on eachother. If you don’t play along by absurd rules that we all openly hate then you get punished for it.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "No one wants a friend, they want a fall guy. No one want’s safety they want power. No one wants to be skilled, they want to be better.";
                Char3name.text = "";
                Char3speech.text = "";

        }
       else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I’m tired.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I’m tired.";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
        }
       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Then get admitted to an asylum? Be arrested for being a possible danger? I think I’m good on that. I can figure this out myself.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 31){
                Char1name.text = "You";
                Char1speech.text = "Nothing bad will happen if you reach out!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Ya? How do you know? Even if I wanted to get that help it would cost an arm and a leg. Luckily I think I’m about to have a spare...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Ya? How do you know? Even if I wanted to get that help it would cost an arm and a leg. Luckily I think I’m about to have a spare...";
                Char3name.text = "";
                Char3speech.text = "";
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
        }


       // after choice 2a
       else if (primeInt == 40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "What?";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 41){
                Char1name.text = "You";
                Char1speech.text = "Is that what you wanted? You want someone to say sorry? Someone to say it’s ok and that everything will work out? You want someone to coddle you and say to forget about it?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 42){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "No! I just know there’s noth-";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 43){
                Char1name.text = "You";
                Char1speech.text = "You know there’s something. You want that something. It’s more than obvious. You aren’t some hardened seven foot tall Jason Vorhees slashing teenagers.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 44){
                Char1name.text = "You";
                Char1speech.text = "You aren’t Hannibal Lecter, you aren’t Anton Chigurh, and you definitely aren’t a killer.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 45){
                Char1name.text = "You";
                Char1speech.text = "Look it’s tough, believe me I know. I also don’t know your history and how that’s affected you.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 46){
                Char1name.text = "You";
                Char1speech.text = "I do know that these problems aren’t just yours to figure out. It doesn’t have to be a professional, it can just be a trusted friend or maybe even a journal you write in. You just need to get these thoughts out of your head to figure them out.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 47){
                Char1name.text = "You";
                Char1speech.text = "You don’t need to forget your problems, you just need to find YOUR solution. Preferably one that doesn’t involve murder...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 48){
                Char1name.text = "You";
                Char1speech.text = "You have a way out of this. As far as I’m concerned I never met you, seriously I don’t know your name... You can turn around and get out of here.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 49){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 50){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";

                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
                NextScene3Button.SetActive(true);
        }

       // after choice 2b
       else if (primeInt == 60){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "WHAT?!!";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 61){
                Char1name.text = "You";
                Char1speech.text = "Oh c'mon you don’t think everyone on this planet doesn’t feel like you? Doesn’t feel like everything’s rigged against them! Life isn’t full of sunshine and rainbows you spoiled little brat!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 62){
                Char1name.text = "You";
                Char1speech.text = "You honestly think you are justified in acting like this, taking someone’s life because you just found out how the world is? At least when I was a kid we got those ideas knocked the hell out of our heads.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 63){
                Char1name.text = "You";
                Char1speech.text = "People are trying to fix these problems and when they can’t be solved shit crumbles.  When it’s all dust people forget and move on! All of YOUR issues are just general garbage people get over.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 64){
                Char1name.text = "You";
                Char1speech.text = "I can’t take you seriously because I know you are just some spoiled brat who want’s to be coddled to Mom’s teat. You probably killed your dad over not being able to go see a concert or something right?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 65){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "No, I killed him over the shit you are saying to me right now…";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 66){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "No, I killed him over the shit you are saying to me right now…";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
                NextScene3Button.SetActive(true);
        }


      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "You can still walk away from all of this. You don’t have to keep doing this if you don’t want to. You really don’t sound like the type of person who would do something like this.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "I just think you need help. You need something that a random stranger isn’t going to give to you.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct(){
                Char1name.text = "You";
                Char1speech.text = "I’m sorry...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 39;
                GameHandler.killerFriendship+=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "You";
                Char1speech.text = "Grow up and stop being so god damn edgy!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59;
                GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene5a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5b");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene5c");
        } //In these quotations above put the name of next scene you want to go to
}
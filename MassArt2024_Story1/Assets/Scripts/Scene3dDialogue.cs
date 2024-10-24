using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene3dDialogue : MonoBehaviour {
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
        public GameObject ArtChar2a;
        public GameObject ArtChar2b; //NonStranger, same logic for multiple as above
        public GameObject ArtBG1; //Background, same logic for multiple as above
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
        public GameObject NextScene5Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Initial visibility settings. Any new images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             NextScene4Button.SetActive(false);
             NextScene5Button.SetActive(false);
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
       else if (primeInt ==2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "The food court is a ghost town of overturned chairs, grime-covered tables, and stale air. The scent of long-spoiled food lingers faintly. The dim lighting flickers as you and the Stranger walk past an abandoned fast food counter.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==3){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Man, I used to hate these places. All the noise, the crowds... but the food? Couldn’t get enough of it.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Have you ever hung out in places like this?";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==5){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "Before you can answer, a figure emerges from behind the counter, wiping their hands on an old apron. The fast food worker, looking like they haven’t seen sunlight in days, stares at you with a vacant expression.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==6){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Fast Food Worker";
                Char3speech.text = "You’re... late. The kitchen's closed... but if you're hungry, I can... make you something… something infested…";
        }
       else if (primeInt ==7){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "They shuffle awkwardly behind the counter, pulling out a stained spatula.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==8){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "You’ve been here this whole time?";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==9){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Fast Food Worker";
                Char3speech.text = "Yeah. Forgot to punch out... when the place closed. Thought maybe someone would come back. But no one did.";
        }
       else if (primeInt ==10){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "They sigh, dropping the spatula.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==11){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Fast Food Worker";
                Char3speech.text = "I was supposed to leave... but I don’t know how anymore. Been here too long.";
        }
       else if (primeInt ==12){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "This guy reaks";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==13){
                Char1name.text = "Narration";
                Char1speech.text = "The worker looks at you, eyes pleading.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==14){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Fast Food Worker";
                Char3speech.text = "You should leave... while you still can.";
        }
       else if (primeInt == 15){
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Fast Food Worker";
                Char3speech.text = "You should leave... while you still can.";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "Lets go to the toy store, wonder what's leftover";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "You";
                Char1speech.text = "Lets go to the clothing store, I want to see what they've got";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

       // after choice 1c
       else if (primeInt == 40){
                Char1name.text = "You";
                Char1speech.text = "This guy bums me out, lets get out of here";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                if(GameHandler.canPark){
                        NextScene3Button.SetActive(true);
                }
                if(GameHandler.canMill){
                        NextScene4Button.SetActive(true);
                }
                if(GameHandler.canBridge){
                        NextScene5Button.SetActive(true);
                }
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "Lets go to the toy store, wonder what's leftover";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "Lets go to the clothing store, I want to see what they've got";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
                Char1name.text = "You";
                Char1speech.text = "This guy bums me out, lets get out of here";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 39;
                //GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene3b"); //Toy Store
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3c"); //Clothes Store
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2a"); //Park
        }
        public void SceneChange4(){
                SceneManager.LoadScene("Scene2c"); //Mill
        }
        public void SceneChange5(){
                SceneManager.LoadScene("Scene4a"); //Bridge
        } //In these quotations above put the name of next scene you want to go to
}
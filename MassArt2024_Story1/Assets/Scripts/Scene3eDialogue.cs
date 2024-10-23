using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene3eDialogue : MonoBehaviour {
        // These are the script variables.
        // For more character images or buttons, duplicate the ArtChar ones listed here and renumber.
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name; //Player & Narrator
        public TMP_Text Char1speech;
        public TMP_Text Char2name; // Stranger
        public TMP_Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //Stranger
        public GameObject ArtChar1b; //Stranger diff pose (change to 1b/1c/1d/etc for multiple poses in same scene)
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar2; //NonStranger, same logic for multiple as above
        public GameObject ArtBG1; //Background, same logic for multiple as above
        public GameObject Choice1a;
        public GameObject Choice1b;
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
             ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
             ArtChar1d.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
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
                
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "You and the stranger explore the upstairs of the building. The rooms this late at night are barren memorials of the past.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "The hallways drenched in a suffocating darkness that is only illuminated by the moonlight and your phone’s screen. The Stranger following you close behind to prevent any attempt at an escape.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "Eventually you make it down the hall to an office with papers haphazardly tossed around. The ceiling full of mold and mildew, exposed wiring the only thing keeping everything together.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 5){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "A miniature golf desk toy missing the ball is placed on a rusted iron desk. Filing cabinets left open with a barely legible sprayed on signature that says “Booblee”.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt ==6){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = " I can imagine the stench of the guy who worked in here. Yelling at young workers to overwork for little pay, then just wandering home and pretending like nothing’s happened.";
        }
        else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "He probably also was the type of guy who tried to get anyone fired he wasn’t friends with, and when he couldn’t, he would just lie to corporate or something.";
        }
        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "He probably also was the type of guy who tried to get anyone fired he wasn’t friends with, and when he couldn’t, he would just lie to corporate or something.";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
        else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "That’s unfair to the manager. They’re a person too. They’ve got a life to live and a paycheck to make also. You can’t just blame them for doing their job";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 21){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "So what do I blame their boss? Do I blame their boss’s boss? Do I blame corporate?! So what I’m supposed to do is just keep going up the chain until we get to “The Company”, or hell to THE WORLD?!";
        }
        else if (primeInt == 22){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "I was just trying to say that managers are under scrutiny from someone else also";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 23){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "The workers are people also. Hell the guys who worked in this mill are putting their butt on the line with industrial death traps just to make enough for a loaf of bread a week while sir Patrick Bateman sits on high judging them.";
        }
        else if (primeInt == 24){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "We really don’t know what this guy was like...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 25){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Ya? Well let’s see this guy's dirty laundry...";
        }
        else if (primeInt == 26){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "The Stranger proceeds to look through the papers scattered about. Hastily reading line by line to sift through the possible mountain of papers you stand on. One paper grabs their attention...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 27){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Think he’s so kind? Think the manager was soooooooooo SAINTLY?! Check this letter out!";
        }
        else if (primeInt == 28){ //Converge
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“Janice, Aniarós Industries has been forced to make cuts to save money. As of today the entire workforce needs to be let go without severance pay of any kind to prepare for the building's closure.”";
        }
        else if (primeInt == 29){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“We will be moving you to one of our more successful facilities out West that isn’t expected to have any downsizing. A representative from our offices will be in contact with you sometime this Thursday.”";
        }
        else if (primeInt == 30){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“We are confident that you will handle this with what is expected of an Aniarós employee. Sincerely, Management.”";
        }
        else if (primeInt == 31){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger takes out another letter and reads it out loud";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 32){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“Janice, we’ve gotten a report about how you’ve been treating employees. We understand you are under a lot of pressure but you can’t be speaking to workers like that.”";
        }
        else if (primeInt == 33){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I have a write up that says you called a worker a “junkie just trying to get a free ride from the company”. You know Tony has been clean for a decade now and has a family to feed. Tony is a tough guy but you can’t be saying these things.";
        }
        else if (primeInt == 34){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“At the very least please consider what this sounds like to those who overhear  these conversations. HR”";
        }
        else if (primeInt == 35){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "You decide to take a look yourself and find a paper that reads:";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 36){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Note";
                Char1speech.text = "“Janice, you have to do something about Bill. That dude is getting on my god damn nerves. I find him smoking all the time because he’s “on break” and when he works he never says a goddamn thing! I know he’s retiring in a few months but this guys needs to go NOW!”";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 37){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Note";
                Char1speech.text = "“If something doesn’t happen I’ll be contacting someone from corporate!” - Oscar J.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 38){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I don’t understand these people. I don’t understand how you can do these things to other people who are just trying to live their life...";
        }
        else if (primeInt == 39){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Why do we have to be like this to each other...";
        }
        else if (primeInt == 40){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "You can’t go about your life worrying about other's affairs";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 41){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "You still have to deal with this at work. You are telling me you work minimum wage for a shitty job and then deal with THESE people?";
        }
        else if (primeInt == 42){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "No, these guys probably made more than minimum if they worked in this building.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 43){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I just don’t see the point of working somewhere to then struggle with these people. What’s the end goal? What’s the point of going on with this just to end up 6 feet under?";
        }
        else if (primeInt == 44){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "It’s getting a little awkward, it might be time to go.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 45){
                Char1name.text = "Narration";
                Char1speech.text = "It’s getting a little awkward, it might be time to go.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                if(GameHandler.canPark){
                        NextScene1Button.SetActive(true);
                }
                if(GameHandler.canMall){
                        NextScene2Button.SetActive(true);
                }
                if(GameHandler.canBridge){
                        NextScene3Button.SetActive(true);
                }
        }

       // after choice 1b
       else if (primeInt == 50){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Office politics and this whole “be polite” stuff is just utter crap. Most people understand when someone hates them but have to save face, it’s disgusting.";
        }
       else if (primeInt == 51){
                Char1name.text = "You";
                Char1speech.text = "Would you prefer it if they just told you the truth?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 52){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Probably not, maybe at least have some taste when telling me so we don’t have to pretend you know?";
        }
       else if (primeInt == 53){
                Char1name.text = "You";
                Char1speech.text = "I really hope I don’t have to see you again";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 54){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
        }
       else if (primeInt == 55){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Fair. See I prefer that over you saying something like...";
        }
       else if (primeInt == 56){
                Char1name.text = "You";
                Char1speech.text = "...Like you are my best friend and I would really appreciate you opening up my ribcage?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 57){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I was going to say “How’s the weather” but that works too.";
        }
       else if (primeInt == 58){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I wonder how it was to work here….maybe we can find something in these piles...";
        }
       else if (primeInt == 59){
                Char1name.text = "Narration";
                Char1speech.text = "The stranger starts to shuffle through the papers that carpet the room. Ignoring any that are stained from the beating of time and only observing the ones that took refuge from the building's history. The Stranger finds some papers of interest they read aloud.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 60){ //Converge
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“Janice, Aniarós Industries has been forced to make cuts to save money. As of today the entire workforce needs to be let go without severance pay of any kind to prepare for the building's closure.”";
        }
        else if (primeInt == 61){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“We will be moving you to one of our more successful facilities out West that isn’t expected to have any downsizing. A representative from our offices will be in contact with you sometime this Thursday.”";
        }
        else if (primeInt == 62){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“We are confident that you will handle this with what is expected of an Aniarós employee. Sincerely, Management.”";
        }
        else if (primeInt == 63){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger takes out another letter and reads it out loud";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 64){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“Janice, we’ve gotten a report about how you’ve been treating employees. We understand you are under a lot of pressure but you can’t be speaking to workers like that.”";
        }
        else if (primeInt == 65){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I have a write up that says you called a worker a “junkie just trying to get a free ride from the company”. You know Tony has been clean for a decade now and has a family to feed. Tony is a tough guy but you can’t be saying these things.";
        }
        else if (primeInt == 66){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "“At the very least please consider what this sounds like to those who overhear  these conversations. HR”";
        }
        else if (primeInt == 67){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "You decide to take a look yourself and find a paper that reads:";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 68){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Note";
                Char1speech.text = "“Janice, you have to do something about Bill. That dude is getting on my god damn nerves. I find him smoking all the time because he’s “on break” and when he works he never says a goddamn thing! I know he’s retiring in a few months but this guys needs to go NOW!”";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 69){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Note";
                Char1speech.text = "“If something doesn’t happen I’ll be contacting someone from corporate!” - Oscar J.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 70){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I don’t understand these people. I don’t understand how you can do these things to other people who are just trying to live their life...";
        }
        else if (primeInt == 71){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Why do we have to be like this to each other...";
        }
        else if (primeInt == 72){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "You can’t go about your life worrying about other's affairs";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 73){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "You still have to deal with this at work. You are telling me you work minimum wage for a shitty job and then deal with THESE people?";
        }
        else if (primeInt == 74){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "You";
                Char1speech.text = "No, these guys probably made more than minimum if they worked in this building.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 75){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I just don’t see the point of working somewhere to then struggle with these people. What’s the end goal? What’s the point of going on with this just to end up 6 feet under?";
        }
        else if (primeInt == 76){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "It’s getting a little awkward, it might be time to go.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 77){
                Char1name.text = "Narration";
                Char1speech.text = "It’s getting a little awkward, it might be time to go.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                if(GameHandler.canPark){
                        NextScene1Button.SetActive(true);
                }
                if(GameHandler.canMall){
                        NextScene2Button.SetActive(true);
                }
                if(GameHandler.canBridge){
                        NextScene3Button.SetActive(true);
                }
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "That’s unfair to the manager. They’re a person too. They’ve got a life to live and a paycheck to make also. You can’t just blame them for doing their job";
                Char2name.text = "";
                Char2speech.text = "";
                GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "Ya I know what you mean, some people are just real pieces of work…";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49;
                GameHandler.killerFriendship+=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene4a");
        }

         //In these quotations above put the name of next scene you want to go to
}
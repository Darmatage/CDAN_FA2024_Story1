using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene3aDialogue : MonoBehaviour {
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
        public GameObject Choice1c;
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
             Choice1c.SetActive(false);
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
    public void Next() {
        primeInt = primeInt + 1;
        if (primeInt == 1) {
            // audioSource1.Play();
        }
        else if (primeInt == 2)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = "Narration";
            Char1speech.text = "As you both sit on the swing set, the Stranger relaxes their posture while gently swaying in their seat.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Playgrounds break my heart...";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "You";
            Char1speech.text = "Oh, I'm...sorry?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "I’ve always wanted to have a group of friends. Ones that were like blood to me. Ones I could make mistakes with and die happy knowing I knew them.";
        }

        else if (primeInt == 6)
        {
            Char1name.text = "You";
            Char1speech.text = "That's... interesting.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Look, just humor me. For my sake... for my sanity, just humor me.";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "Narration";
            Char1speech.text = "You feel if you don't listen to them, this could turn sour quick.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "I hear all the time about childhood friends, and how they have these lasting memories, and hear how people are going to crazy places and doing fun stuff.";
        }

        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "I didn’t get that chance and I don’t think I ever will. How do I keep on going knowing it might only ever be me?";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // Choice for "You enjoy your own company"
            Choice1b.SetActive(true); // Choice for "You keep looking"
        }

        // after choice 1a
        
        else if (primeInt == 20)
            {
                Char1name.text = "You";
                Char1speech.text = "You enjoy your own company. In life we aren't guaranteed companionship in any way...";
                Char2name.text = "";
                Char2speech.text = "";
            }
            else if (primeInt == 21)
            {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I mean, it's not like I can have a party by myself or go to concerts on my own...";
            }
            else if (primeInt == 22)
            {
                Char1name.text = "You";
                Char1speech.text = "Of course you can! Get yourself a cake! Go to a bunch of local shows.";
                Char2name.text = "";
                Char2speech.text = "";
            }
            else if (primeInt == 23)
            {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "That implies I know someone who can buy me some beer to begin with.";
            }
            else if (primeInt == 24)
            {
                Char1name.text = "Narration";
                Char1speech.text = "It might be best if you take them somewhere else.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); //Go to Mall
                NextScene2Button.SetActive(true); //Go to Mill
            }

            // after choice 1b
            else if (primeInt == 30)
            {
                Char1name.text = "You";
                Char1speech.text = "You keep looking. You aren't going to enjoy everyone's company and they might not enjoy yours...";
                Char2name.text = "";
                Char2speech.text = "";
            }
            else if (primeInt == 31)
            {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Well my 'friends' spread rumors about me saying I want to be a lizard man...";
            }
            else if (primeInt == 32)
            {
                Char1name.text = "You";
                Char1speech.text = "So? Sounds like they did you a favor by showing you they weren’t worth your time.";
                Char2name.text = "";
                Char2speech.text = "";
            }
            else if (primeInt == 33)
            {
                Char1name.text = "Narration";
                Char1speech.text = "The stranger shuffles uncomfortably on the swing. It might be best to go somewhere else now.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); //Go to Mall
                NextScene2Button.SetActive(true); //Go to Mill
            }
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                GameHandler.killerFriendship+=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39;
                GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("");
        } //In these quotations above put the name of next scene you want to go to
}

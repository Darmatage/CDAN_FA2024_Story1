using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene3bDialogue : MonoBehaviour {
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
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Just some toys, huh? Brings back memories. My babysitter used to just cram me in front of a pile of these, while they were on their phone the entire day.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "You had a babysitter? What, they didn’t take you outside or anything?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Nope. I spent hours in places like this. Toys were my 'friends'—if you can call them that. Didn’t even know how to talk to people back then.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "Narration";
            Char1speech.text = "A sudden movement catches your eye. A figure steps out from behind one of the counters—a toy store worker, exhausted and worn out.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Toy Store Worker";
            Char3speech.text = "H-Hey! What are you doing here? The store’s... closed.";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "No kidding. Looks like you’ve been here longer than these toys.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Toy Store Worker";
            Char3speech.text = "I—I didn’t punch out... I-I was just... taking inventory... and now the mall’s been closed down, and I think they forgot about me.";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "So, you've just been living here? Surrounded by all this?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Toy Store Worker";
            Char3speech.text = "It’s not so bad. I have the toys to keep me company, but I should... really leave. I just... don’t know where to go.";

        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "What about you? Think you’re ready to leave this place? Or are you planning to stay here forever like the rest of these forgotten things?";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true); // Choice for "Let’s get out of here, all of us."
            NextScene2Button.SetActive(true); // Choice for "This is pointless. Let’s just move on."
            NextScene3Button.SetActive(true); // Choice for "This mall is so boring dude, let’s just rush to the next place."
        }

    //Please do NOT delete this final bracket that ends the Next() function:
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
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
                Char3name.text = "";
                Char3speech.text = "";
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
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 39;
                GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene3c");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3d");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene4a");
        } //In these quotations above put the name of next scene you want to go to
}
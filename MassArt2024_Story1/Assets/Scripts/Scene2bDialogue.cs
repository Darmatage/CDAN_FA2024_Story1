using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene2bDialogue : MonoBehaviour {
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
                GameHandler.canMall=false;
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "You reach the mall and the place is empty, the place has been closed recently and front doors were locked shut.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
        }
       else if (primeInt ==4){
                Char1name.text = "You";
                Char1speech.text = "Follow me, there’s a way in through the back side";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==5){
                Char1name.text = "Narration";
                Char1speech.text = "You lead the stranger to a hidden opening at the backside of the mall and enter.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "What’s happened to society?";
        }
       else if (primeInt ==8){
                Char1name.text = "You";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "What happened to people coming here to have fun and to hang out?";
        }
       else if (primeInt ==10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "They closed this place because it was more profitable to shop online, yet they blame us now for being stuck on our phones";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "We lose a place to hang and meetup only then for us to be blamed for not going out more";
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
                Char2speech.text = "hen why did you bring me here?";
        }
       else if (primeInt == 21){
                Char1name.text = "You";
                Char1speech.text = "There were a few places around here I was excited for when I came here";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Like?";
        }
       else if (primeInt == 23){
                Char1name.text = "You";
                Char1speech.text = "Like...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 24){
                Char1name.text = "You";
                Char1speech.text = "Like...";
                Char2name.text = "";
                Char2speech.text = "";
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
                NextScene3Button.SetActive(true);
        }


       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "You";
                Char1speech.text = "There were a few places around here I was excited for when I came here";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Like?";
        }
       else if (primeInt == 32){
                Char1name.text = "You";
                Char1speech.text = "Like...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 33){
                Char1name.text = "You";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
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
                Char1speech.text = "Everytime my parents took us here I'd be bored out of my mind";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "I miss when this place was still up and running. Fond memories with my parents and friends";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                GameHandler.killerFriendship+=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3c");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene3d");
        } //In these quotations above put the name of next scene you want to go to
}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene3cDialogue : MonoBehaviour {
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
        public GameObject ArtChar2a; //NonStranger, same logic for multiple as above\
        public GameObject ArtChar2b;
        public GameObject ArtBG1; //Background, same logic for multiple as above
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Initial visibility settings. Any new images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtBG1.SetActive(true);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "You’re into this stuff? Never cared much about fashion. Just another way people try to fit into molds they don’t belong in.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Narration";
                Char1speech.text = "The Stranger grabs a moth-eaten jacket and holds it up.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==4){
                Char1name.text = "You";
                Char1speech.text = "I dunno, clothes can be fun. It’s not always about fitting in. Sometimes it’s about expressing yourself.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==5){
                Char1name.text = "Narration";
                Char1speech.text = "Before the Stranger can respond, a tired voice speaks up from behind a clothing rack.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==6){
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Clothing Store Worker";
                Char3speech.text = "Expressing yourself... that’s what I used to tell customers.";
        }
        else if (primeInt ==7){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The worker, wearing a store-branded name tag that’s barely legible, steps into the open. Their eyes are bloodshot, like they haven’t slept in days.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==8){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Clothing Store Worker";
                Char3speech.text = "But it’s all a lie. Doesn’t matter what you wear. No one really cares.";
        }
        else if (primeInt ==9){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Sounds like you’ve given up.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==10){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Clothing Store Worker";
                Char3speech.text = "Far worse actually, I’m aware. If someone actually talked to you, they’ll figure you out real quick…";
        }
        else if (primeInt ==11){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The worker gestures weakly at the Stranger to a row of clothes.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt ==12){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Clothing Store Worker";
                Char3speech.text = "There are plenty of ways to find a getup, even here. You certainly have a skill for it. No worries…There are no mirrors in here anymore.";
        }
       else if (primeInt == 13){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "So uhh…how do you feel about this? I mean I would love to play dress up, but like…what are you thinking?";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // function Choice1aFunct()
                NextScene2Button.SetActive(true); // function Choice1bFunct()
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3d");
        } //In these quotations above put the name of next scene you want to go to
}
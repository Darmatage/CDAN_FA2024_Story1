using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        // These are the script variables.
        // For more character images or buttons, duplicate the ArtChar ones listed here and renumber.
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       public AudioSource SFX_stabby;
        private bool allowSpace = true;

// Initial visibility settings. Any new images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
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
                GameHandler.canPark=true;
                GameHandler.canMall=true;
                GameHandler.canMill=true;
                GameHandler.canBridge=false;
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "It’s been a stressful week that has tested your sanity and pummeled your patience. You decide to take some time in the park to relax before the nagging feeling of responsibilities return to you and you have to head home.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Narration";
                Char1speech.text = "The silence of the night and the whispers of the wind cause you to close your eyes for a moment.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "You";
                Char1speech.text = "!!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char2speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(2f);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Hey";
        }
       else if (primeInt == 6){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger brandishes a small knife above your waist as they stand concealing the light behind them.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
        }
       else if (primeInt == 8){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "You know any cool spots?";
               
        }
       else if (primeInt == 9){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "What";
                Char2name.text = "";
                Char2speech.text = "";

        }
       else if (primeInt == 10){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Cool spots. To have fun… Know any?";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger forces you up and holds the knife to you. They're probably not letting you go so you might as well do what they ask.";
                Char2name.text = "";
                Char2speech.text = "";

                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
                NextScene3Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I want to see a cool spot";
        }
       else if (primeInt == 31){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger forces you up and holds the knife to you. They're probably not letting you go so you might as well do what they ask.";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Ok, cool… I’ll follow you there";
                GameHandler.killerFriendship+=1;
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice1bFunct(){

                Char1name.text = "Narration";
                Char1speech.text = "The stranger quickly moves their knife to your forearm. The cold and crusty metal is swiped across your skin to draw blood.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                GameHandler.killerFriendship-=1;
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;

        if (primeInt == 29)
        {
            SFX_stabby.Play();
        }

    }

    public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2c");
        }
}
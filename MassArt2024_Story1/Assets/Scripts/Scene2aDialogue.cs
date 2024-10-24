 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
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
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
        public GameObject nextButton;
        public AudioSource SFX_stabby;
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
             Choice1c.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             NextScene4Button.SetActive(false);
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
        if (primeInt == 1)
        {
            // audioSource1.Play();
        }
        else if (primeInt == 2)
        {
            GameHandler.canPark=false;
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Wha- a playground? I didn’t know I was following a comedian. I’m not some toddler you know!";
            
        }


        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Wha- a playground? I didn’t know I was following a comedian. I’m not some toddler you know!";
            //gameHandler.AddPlayerStat(1);
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1cFunct()
            nextButton.SetActive(false);
            allowSpace = false;
        }

        // after choice 1a
        else if (primeInt == 5)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Are you calling me some moody teenager?!!";
        }
        else if (primeInt == 6)
        {
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "No! There was this one movie where an ADULT man had to fight like 7 evil exes and in this scene he’s sitting wi-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "I don’t need to hear about your pixie  girl  fetish.";
        }
        else if (primeInt == 8)
        {
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Ok I don’t think she deserves the amount of hate some people bring to her. She has some good traits. I mean the book and movie have 2 different endings and you can argue th-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            ArtChar1d.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "SHE EXISTS TO GIVE A PEDO A WAY OUT!!!";
        }
        else if (primeInt == 10)
        {
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "...";
        }
        else if (primeInt == 12)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "Narration";
            Char1speech.text = "You and the stranger sit on the swing set like moody teenagers for a moment talking about how business men perceive how teenagers act";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "Narration";
            Char1speech.text = "You and the stranger sit on the swing set like moody teenagers for a moment talking about how business men perceive how teenagers act";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        // after choice 1b
        else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "It’s boring. There’s nothing here. You just brought me here because you think I can be pushed around, that I can just be fucked with!";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "I’m not going to be pushed around by anyone!";
        }

        else if (primeInt == 22)
        {
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Wait!..";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 23)
        {
            Char1name.text = "You";
            Char1speech.text = "This place was close by. It was hard to think of anything and I knew it was near us. I didn’t mean anything by it, I swear!";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 24)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "Right... you just don’t want to die...";
        }

        else if (primeInt == 25)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "...Just take me somewhere else.";
        nextButton.SetActive(false);
        allowSpace = false;
        NextScene1Button.SetActive(true);
            if(GameHandler.canMall){
                NextScene2Button.SetActive(true);
            }
            if(GameHandler.canMill){
                NextScene3Button.SetActive(true);
            }
            if(GameHandler.canBridge){
                NextScene4Button.SetActive(true);
            }
        }

        // after choice 1c
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "I have a FUCKING knife pointed at you and you want to say shit like this?!";
            if (primeInt == 30)
            {
                SFX_stabby.Play();
            }
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Stranger";
            Char2speech.text = "If you don't want little Timmy to find you lying limp bleeding all over the woodchips, I advise we leave. I may be a murderer but I’m not a monster who’s going to ruin some kids childhood.";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            if(GameHandler.canMall){
                NextScene2Button.SetActive(true);
            }
            if(GameHandler.canMill){
                NextScene3Button.SetActive(true);
            }
            if(GameHandler.canBridge){
                NextScene4Button.SetActive(true);
            }
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Playgrounds aren’t just for kids. Haven’t you ever seen moody teenagers in movies?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 4;
                GameHandler.killerFriendship+=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "What’s wrong with playgrounds? You can come here to play basketball, use the monkey bars as pull ups, and there’s no age limit to using the swings.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Well if I’m going to be babysitting I might as well take you to something familiar.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a"); //Swings
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b"); //Mall
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2c"); //Mill
        }
        public void SceneChange4(){
                SceneManager.LoadScene("Scene4a"); //Bridge
        }
}
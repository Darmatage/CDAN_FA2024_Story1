using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
// DO NOT FORGET TO CHANGE THIS PUBLIC CLASS NAME WHEN COPY AND PASTING !!!
public class Scene2cDialogue : MonoBehaviour {
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
                GameHandler.canMill=false;
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "The Old mill, a sight for sore eyes but a place where most of the local teenagers have made hazardous abode in when trying to act like prepubescent adults away from Father’s eyes. The building is littered with beer bottles, and graffiti";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Cool place. I didn’t know something like this existed in town…";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "It’s also funny you took someone with a knife at your back here…alone…where no one would interrupt us...";
        }
       else if (primeInt ==5){
                Char1name.text = "You";
                Char1speech.text = "Murderers and psychopaths don’t ask their victim to take them to a “cool place”";
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
                Char2speech.text = "People come here often? There’s more bottles in here than a redemption center";
        }
       else if (primeInt ==8){
                Char1name.text = "You";
                Char1speech.text = "Ya a lot of the local kids come here to drink and talk gossip. I didn’t come here often but it has it’s memories";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Sounds like this place is well known….yet the building is still here?";
        }
       else if (primeInt ==10){
                Char1name.text = "You";
                Char1speech.text = "I heard it was supposed to be torn down a few years ago but the Mayor just didn’t bother with moving forward with it. Apparently it’s not causing any problems to the town in his eyes";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Makes sense to me";
        }
       else if (primeInt ==12){
                Char1name.text = "Narration";
                Char1speech.text = "The stranger starts to look around and admire the brick carcass you stand in. They seems fascinated by the rusted bones of scaffolding that stand above you.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "So what was this place before it was shut down?";
        }
       else if (primeInt ==14){
                Char1name.text = "You";
                Char1speech.text = "Honestly I don’t know. It felt like it’s been closed down forever and the signs are rusted beyond belief. We all just called it “The Mill” because it sounded cool";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Well I want to see more of this place, how do we get up higher?";
        }
       else if (primeInt ==16){
                Char1name.text = "Narration";
                Char1speech.text = "You remember there’s two ways up. A rusted set of stairs that if not already should be on the verge of collapsing, or a ladder full of splintered metal that you remember a friend getting Tetanus from";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "Narration";
                Char1speech.text = "You remember there’s two ways up. A rusted set of stairs that if not already should be on the verge of collapsing, or a ladder full of splintered metal that you remember a friend getting Tetanus from";
                Char2name.text = "";
                Char2speech.text = "";
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
                Char2speech.text = "Show me these stairs, I’m really curious what’s up there!";
        }
       else if (primeInt == 21){
                Char1name.text = "Narration";
                Char1speech.text = "You hesitantly make your way to the far end of the mill where  a teenage den was placed in front of the staircase. The stranger grows eager and digs their knife harder into your back to keep you moving.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 22){
                Char1name.text = "Narration";
                Char1speech.text = "The stairs creak in discomfort as their brittle bodies barely cling to the supports made for them. Each step occasionally being accompanied by fussy crackling of rust and loosened metal";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 23){
                Char1name.text = "Narration";
                Char1speech.text = "Half way up, the stairs make a monstrous yell to signal it’s forfeit of you and your “friends” weight.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "?!!?!!!";
        }
       else if (primeInt == 25){
                Char1name.text = "You";
                Char1speech.text = "RUN!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 26){
                ArtChar1a.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "You both start to chase up the stairs skipping every odd step to make time. Despite this the stairs wish to drag you both down with them and hasten their fall as metal rips itself from the wall and supports.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 27){
                Char1name.text = "Narration";
                Char1speech.text = "You know you could make it out of this if the Stranger wasn’t tugging on your shirt to keep you from getting too far away.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 28){
                Char1name.text = "Narration";
                Char1speech.text = "As your adrenaline is at it’s high and you reach the top you use all your might to toss yourself forward, the stranger following in your dive.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 29){
                Char1name.text = "Narration";
                Char1speech.text = "The stairs make one final wail as it all crumbles without you. It’s life as a support to help workers go from one floor the next is over, now a pile of useless metal that no one can rely on.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 30){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
        }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "That was badass! Let’s see more of this place!";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Oh cool a ladder! I think I saw it back here!";
        }
       else if (primeInt == 41){
                Char1name.text = "Narration";
                Char1speech.text = "The stranger forces you to lead despite being aware of the direction you need to go.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 42){
                Char1name.text = "Narration";
                Char1speech.text = "When you reach the ladder you see some hinges jutting out from the wall. The ladder is a gaunt imitation of what it was while in service. In it’s current state it seems to refuse to let go of this building and it’s duty to help those ascend to a higher level.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 43){
                ArtChar1a.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "You are forced to go first and reluctantly grab on as you try to be careful of the metal scales trying to prick you. The Stranger follows covering their hand with remnants of their sweatshirt.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 44){
                Char1name.text = "Narration";
                Char1speech.text = "The initial climb was fine until half way the ladder starts to cry out from the weight of two strangers using it.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 45){
                Char1name.text = "Narration";
                Char1speech.text = "The ladder stays strong to allow passage but reluctantly starts to give in due to the neglect over the years. The remaining hinges start to leap away from the wall with concrete being spat out.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 46){
                Char1name.text = "Narration";
                Char1speech.text = "The ladder yelps as the rusted supports snap and the body is split in half. You and the stranger decide to hurry up before the ladder gives in to the overtime you demanded from it.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 47){
                Char1name.text = "Narration";
                Char1speech.text = "Knowing that Tetanus would be worse than broken bones you hold up the path as you double check your hands for the sharp metal shards.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 48){
                ArtChar1a.SetActive(true);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger is recklessly moving upwards trying to prolong their short life. They start to poke you in the legs to spur you forward.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 49){
                Char1name.text = "Narration";
                Char1speech.text = "The ladder whips out under both of you but you manage to keep on a steady grip. Eventually you make it up and without a second though help the Stranger up.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 50){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "...";
        }
       else if (primeInt == 51){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Now that was cool as fuck! This place rules dude!";
        }
       else if (primeInt == 52){
                Char1name.text = "You";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 53){
                Char1name.text = "You";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "There’s some stairs…but I don’t think it’s very re-";
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
                Char1speech.text = "There should be a ladder around here somewhere. We just need to be careful bec-";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3e");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("");
        } //In these quotations above put the name of next scene you want to go to
}
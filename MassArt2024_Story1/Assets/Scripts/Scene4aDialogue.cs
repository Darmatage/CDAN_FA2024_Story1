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
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
        public GameObject ArtChar2a; //NonStranger, same logic for multiple as above
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;
        public GameObject ArtBG1; //Background, same logic for multiple as above
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice3a;
        public GameObject Choice3b;
        public GameObject Choice3c;
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
             ArtChar1c.SetActive(false);
             ArtChar1d.SetActive(false);
             ArtChar1e.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtChar2d.SetActive(false);
             ArtChar2e.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice3a.SetActive(false);
             Choice3b.SetActive(false);
             Choice3c.SetActive(false);
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
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I have to thank you for showing me around. Even if it was against your will you did show me some cool spots like I asked.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==5){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger steps closer";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6   ){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
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
                ArtChar1b.SetActive(false);
                ArtChar1d.SetActive(true);
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
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "Nothing bad will happen if you reach out!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 32){
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);
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
                ArtChar1d.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "What?";
                Char3name.text = "";
                Char3speech.text = "";

        }
       else if (primeInt == 41){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "Is that what you wanted? You want someone to say sorry? Someone to say it’s ok and that everything will work out? You want someone to coddle you and say to forget about it?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 42){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "No! I just know there’s noth-";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 43){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
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
                nextButton.SetActive(false);
                allowSpace = false;

                if(GameHandler.canEnd1){
                Choice3a.SetActive(true);
                }
                if(GameHandler.canEnd2){
                Choice3b.SetActive(true); 
                }
                if(GameHandler.canEnd3){
                Choice3c.SetActive(true); 
                }
        }

       // after choice 2b
       else if (primeInt == 60){
                ArtChar1d.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "WHAT?!!";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 61){
                ArtChar1d.SetActive(false);
                ArtChar1a.SetActive(true);
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
                ArtChar1d.SetActive(true);
                ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "No, I killed him over the shit you are saying to me right now…";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 66){
                ArtChar1d.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "No, I killed him over the shit you are saying to me right now…";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                if(GameHandler.canEnd1){
                Choice3a.SetActive(true);
                }
                if(GameHandler.canEnd2){
                Choice3b.SetActive(true); 
                }
                if(GameHandler.canEnd3){
                Choice3c.SetActive(true); 
                }
        }
        

       // after choice 3a
       else if (primeInt == 70){
                ArtChar1e.SetActive(true);
                ArtChar1a.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger tightens their stance and broadens their shoulders. They start to move closer to you as they trudge their way through the air with a tight grip around the blade.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 71){
                ArtChar1b.SetActive(true);
                ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "It’s people like you that confuses me.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 72){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I know I had you at knife point but even then you refused to give me any respect, any compassion, any semblance of understanding! You have a bigger death wish than me!";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 73){
                ArtChar1c.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I don’t know who you are but if you can’t handle me then I feel bad for whoever has to deal with YOU!";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 74){
                Char1name.text = "Narration";
                Char1speech.text = "The stranger dives into you. You try to dodge out of the way but they were able to adjust their step to plunge the knife into your knee. You scream out in pain and fall over. The stranger moves closer to lay on top of you.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
            if (primeInt == 74)
            {
                SFX_stabby.Play();
            }
        }
       else if (primeInt == 75){
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Something tells me I’m doing a lot of people a favor right now.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 76){
                ArtChar1e.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The snarky teenager takes the blade and stabs it into you wherever he can reach. Your clothes are stained wine red as you are being assaulted.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
            if (primeInt == 76)
            {
                SFX_stabby.Play();
            }
        }
       else if (primeInt == 77){
                Char1name.text = "Narration";
                Char1speech.text = "You are struggling to keep your eyes open.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 78){
                Char1name.text = "Narration";
                Char1speech.text = "The last thing you see is the teenager aggressively kicking you to the side of the bridge as they toss you over into the river. Your vision turned black as soon as you went underwater.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 79){
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "You were found tomorrow afternoon. No suspect was identified.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 80){
                Char1name.text = "Narration";
                Char1speech.text = "You were found tomorrow afternoon. No suspect was identified.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                NextScene1Button.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;

        }

       // after choice 3b
       else if (primeInt == 90){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "You are just some random person. Wrong place, wrong time...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 91){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I appreciate you humoring me. I just wanted to feel like I did something.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 92){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "My parents never let me out of their sight. Eventually when they released that leash it was too late.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 93){
                ArtChar1d.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I feel bad for what I did to my Dad… I hate him, but I didn’t want him dead. It just kinda happened...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 94){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "He likes control. Everything being a certain way. He’s a traditional old fashioned type of guy.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 95){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "Mom tried, but her fix was to tell me to ignore him. At least she got to leave the house...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 96){
                ArtChar1b.SetActive(true);
                ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I’ll be honest... I wasn’t going to kill you...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 97){
                ArtChar1d.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I can’t... I just couldn't bring myself to double down I guess.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 98){
                Char1name.text = "Narration";
                Char1speech.text = "The stranger slowly makes their way to the edge as they carefully climb the railing. They look at you with shoulders slack and head held up high.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 99){
                ArtChar1d.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I just wanted someone to know I was here";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 100){
                Char1name.text = "Narration";
                Char1speech.text = "Before any words were exchanged, any actions on your part could be performed, the teenager takes the kitchen knife and sweeps it into their neck. They let the wind take them as they fall backwards. Their body dives into the water with little to no splash, very little streaks of blood stain the river before disappearing shortly after.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
            if (primeInt == 100)
            {
                SFX_stabby.Play();
            }
        }
       else if (primeInt == 101){
                ArtChar1d.SetActive(false);
                ArtChar1b.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "The stranger is gone. You don’t see the body surface. You can’t see the blood.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 102){
                Char1name.text = "Narration";
                Char1speech.text = "You go home";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 103){
                Char1name.text = "Narration";
                Char1speech.text = "You go home";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                NextScene2Button.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
        }

       // after choice 3c
       else if (primeInt == 110){
                ArtChar1c.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I don’t understand why it has to be so hard. I don’t understand why I have to pussy out like this!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 111){
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I...I wasn’t going to kill you.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 112){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I was hoping that if I did something like this then I would be able to push past this wall and...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 113){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I wanted someone to know I was alive...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 114){
                ArtChar1d.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I wanted you to see me do it...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 115){
                Char1name.text = "Narration";
                Char1speech.text = "The stranger shuffles around waving the knife as they struggle to figure out where to turn the knife. They start to shiver violently, their eyes start to water as they try to keep a gaze on you.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

        }
        else if (primeInt == 116){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "???";
                Char3speech.text = "Casey?!";
        }
        else if (primeInt == 117){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "A large man rushes over to the teenager. He appears rough with dirt all over. Despite his exterior you can tell he’s doing everything he can to not cry.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 118){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "Dad?!!!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 119){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Casey thank god I found you! I’ve been looking everywhere for you!";
        }
       else if (primeInt == 120){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "Dad how are you alive?!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 121){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "You surprised me when you took out the knife. I hit my head on the counter pretty bad but I’m ok.";
        }
        else if (primeInt == 123){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "So I didn’t even hurt you...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 124){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Of course not! Now look let’s get back home and talk this ou-";
        }
        else if (primeInt == 125){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "No! I’m not going back home! I’m tired of this Dad!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 126){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(true);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Casey you are coming home this instant!";
        }
        else if (primeInt == 127){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "Dad just fucking listen to me!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 128){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "I don’t mean to get in the middle like this bu-";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 129){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Oh sorry pal. Look I apologize for wha-";
        }
        else if (primeInt == 130){
                Char1name.text = "You";
                Char1speech.text = "It’s fine...But look, your kid needs help";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 131){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "You can say that again...";
        }
        else if (primeInt == 132){
                Char1name.text = "You";
                Char1speech.text = "No I mean they need a therapist or something.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 133){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Excuse me?";
        }
        else if (primeInt == 134){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 135){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "They have a lot on their mind that they need help with. They need someone to talk to.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 136){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "So they can talk to me. They know I’m here to listen. I don’t need to pay some therapist to do what I can do.";
        }
        else if (primeInt == 137){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "No matter what anything that happens in the family stays in the family";
        }
        else if (primeInt == 138){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "I understand that but they don’t seem comfortable talking to you about these issues...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 139){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(true);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "I doubt that. Casey’s a good kid and if they need help they can talk to ME, THEIR FATHER!";
        }
        else if (primeInt == 140){
                ArtChar2a.SetActive(true);
                ArtChar2d.SetActive(false);

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 141){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "Dad I don’t want to talk about this.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 142){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "I’m glad you agree.";
        }
        else if (primeInt == 143){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "With you, Dad… I don’t want to talk about it with you.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 144){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Casey...";
        }
        else if (primeInt == 145){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "Dad...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 146){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Your Mother mentioned she’s had a hard time talking to you. She brought up the idea of therapy and I told her it was stupid...";
        }
        else if (primeInt == 147){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "I don’t want you doing this but if you think that’s what you need then at least keep the family matters private...";
        }
        else if (primeInt == 148){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Casey";
                Char2speech.text = "Sure whatever...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 149){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "...";
        }
        else if (primeInt == 150){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "I’m sorry for any trouble that was caused. I would appreciate if no charges would  be brought up over this.";
        }
       else if (primeInt == 151){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "Ya no problem, honestly I kinda get where Casey is coming from.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 152){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Casey's Dad";
                Char3speech.text = "Good to hear. Do you need a ride back home?";
        }
        else if (primeInt == 153){
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "Sure I would appreciate that.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 154){
                Char1name.text = "Narration";
                Char1speech.text = "You, Casey, and Casey’s Father walk back to a beaten up last decades pick up truck. The car ride is full of silence with the occasional conversation from you and Casey. The Father tries to butt in but only makes the situation more awkward. You can tell he’s trying.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 155){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                Char1name.text = "Narration";
                Char1speech.text = "Eventually you are dropped off right in front of the entrance to your home. You wave as the pick up truck drives away into the distance. The sun starts to rise and birds begin to chirp.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 156){

                Char1name.text = "Narration";
                Char1speech.text = "You are reminded you have work today but decide after all that it’s best to call in sick.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 157){
                Char1name.text = "Narration";
                Char1speech.text = "You hope Casey is doing ok...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 158){
                Char1name.text = "Narration";
                Char1speech.text = "You hope Casey is doing ok...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                NextScene3Button.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
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
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 59;
                GameHandler.killerFriendship-=1; //Change to +=1 or -=1 for friendship change
                GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().friendshipTest();
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "All I wanted was to see some places and all you did was be an absolute dickweed the whole time.";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 69;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I know if I let you go I’ll go to jail. I wouldn’t doubt if there’s already been witnesses to me dragging you along.";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 89;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Stranger";
                Char2speech.text = "I can’t... I really can’t...";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 109;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
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
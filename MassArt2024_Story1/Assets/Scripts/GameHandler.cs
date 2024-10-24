using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour{

    public static int killerFriendship;
    public static bool canPark = true;
    public static bool canMall = true;
    public static bool canMill = true;
    public static bool canToy = true;
    public static bool canCloth = true;
    public static bool canFood = true;
    public static bool canBridge = false;
    public static bool GameisPaused = false;
    public static bool canEnd1 = false;
    public static bool canEnd2 = false;
    public static bool canEnd3 = false;
    public Texture2D cursorArrow;
    public TMP_Text scoreText;
    public GameObject pauseMenuUI;
    public AudioMixer mixer;
    public static float volumeLevel = 1.0f;
    private Slider sliderVolumeCtrl;

    void Awake()
    {
        SetLevel(volumeLevel);
        GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
        if (sliderTemp != null)
        {
            sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
            sliderVolumeCtrl.value = volumeLevel;
        }
    }

    void Start()
    {
        pauseMenuUI.SetActive(false);
        GameisPaused = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void friendshipTest(){


        if (killerFriendship < 0){

            GameHandler.canEnd1=true;
            GameHandler.canEnd2=false;
            GameHandler.canEnd3=false;
        }
        if (killerFriendship > -1){

            GameHandler.canEnd1=false;
            GameHandler.canEnd2=true;
            GameHandler.canEnd3=false;

        }
        if (killerFriendship > 2){

            GameHandler.canEnd1=true;
            GameHandler.canEnd2=false;
            GameHandler.canEnd3=true;

        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused) { Resume(); }
            else { Pause(); }
        }
        // Stat tester:
        //if (Input.GetKey("p")){
        //       Debug.Log("Player Stat = " + playerStat1);
        //
        
        if (GameHandler.canPark==false && GameHandler.canMall==false && GameHandler.canMill==false){
            GameHandler.canBridge=true;
        } 

        string killerFriendshipstring = killerFriendship.ToString();
        scoreText.SetText(killerFriendshipstring);
        return;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        volumeLevel = sliderValue;
    }


    public void StartGame()
    {
        SceneManager.LoadScene("Warning");
    }

    public void Warning()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        killerFriendship = 0;
        // Please also reset all static variables here, for new games!
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }
}
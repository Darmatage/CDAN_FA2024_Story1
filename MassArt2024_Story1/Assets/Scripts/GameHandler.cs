using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour
{

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
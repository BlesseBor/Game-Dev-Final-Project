using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int currentLevel;
    [SerializeField] int nextLevel;
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject introVid;
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject inGameScreen;
    [SerializeField] private GameObject skipButton;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject completeLevel;
    [SerializeField]private bool isGameActive=false;
    // void Start()
    // {
    //     titleScreen.gameObject.SetActive(true);
    //     // gameOverText.gameObject.SetActive(false);
    //     // timeScoreText.gameObject.SetActive(false);
    // }

    private void Awake()
    {
        // titleScreen.gameObject.SetActive(true);
        // inGameScreen.gameObject.SetActive(false);
        pauseScreen.SetActive(false);
    }
    
    public void DisplayGameOver()
    {
        isGameActive =  false;
        gameOverScreen.gameObject.SetActive(true);
        inGameScreen.gameObject.SetActive(false);
        // timeScoreText.gameObject.SetActive(false);
        // ghoulSpawner.isSpawning = false; // Stop spawning ghouls when the game is over
    }
     public void DisplayCompleteLevel()
    {
        isGameActive =  false;
        completeLevel.gameObject.SetActive(true);
        inGameScreen.gameObject.SetActive(false);
        // timeScoreText.gameObject.SetActive(false);
        // ghoulSpawner.isSpawning = false; // Stop spawning ghouls when the game is over
    }

    public bool IsGameActive()
    {
        return isGameActive;
    }

    public void RestartGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // StartGame();
        isGameActive =  true;
        Time.timeScale = 1;
        SceneManager.LoadScene(currentLevel);

        
    }

    public void StartGame()
    {
        isGameActive =  true;
        titleScreen.gameObject.SetActive(false);
        introVid.gameObject.SetActive(true);
        skipButton.gameObject.SetActive(false);
        Invoke("DelayedSkip", 3f);
        Invoke("StopIntro",54f);
        

        // SceneManager.LoadScene(2);
        // SceneManager.LoadScene(1);
        // titleScreen.gameObject.SetActive(false);
        // inGameScreen.gameObject.SetActive(true);
        // gameOverText.gameObject.SetActive(false);

    }

    public void Quit()
    {
        Application.Quit();

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseScreen.activeInHierarchy && IsGameActive())
                PauseGame(false);
            else    
                PauseGame(true);

        }
    }
    
    public void PauseGame(bool status)
    {
        pauseScreen.SetActive(status);

        if (status)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void ExitGame()
    {
        // titleScreen.gameObject.SetActive(true);
        // inGameScreen.gameObject.SetActive(false);
        SceneManager.LoadScene(1);
    }

    private void StopIntro()
    {
        introVid.gameObject.SetActive(false);
        SceneManager.LoadScene(nextLevel);
    }

    public void SkipIntro()
    {
        isGameActive =  true;
        SceneManager.LoadScene(nextLevel);
    }

    private void DelayedSkip()
    {
        skipButton.gameObject.SetActive(true);
    }

    public void NextLevel()
    {
        isGameActive =  true;
        SceneManager.LoadScene(nextLevel);
    }

    public void SoundVolume()
    {

    }

    public void MusicVolume()
    {
        
    }

}

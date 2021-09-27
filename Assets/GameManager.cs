using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool gameRunning = false;
    public GameObject scoreCanvas;
    public GameObject gameOverCanvas;
    public GameObject startGameCanvas;
    public static int gameSpeed = 12;

    void Start()
    {
        Time.timeScale = 0;
        scoreCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        startGameCanvas.SetActive(true);
        gameSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameRunning){
            Time.timeScale = 1;
            gameRunning = true;
            scoreCanvas.SetActive(true);
            startGameCanvas.SetActive(false);
        }   
    }

    public void GameOver(){
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
    }

    public void ResetGame(){
        gameRunning = false;
        SceneManager.LoadScene(0);
    }
}

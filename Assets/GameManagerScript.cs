using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject winnerUI;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale=0f;
    }

    public void winner()
    {
        winnerUI.SetActive(true);
        Time.timeScale=0f;
    }
    
}



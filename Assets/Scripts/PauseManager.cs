using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public Button pauseButton;
    public GameObject player;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        player.GetComponent<Controller>().enabled = false;
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        player.GetComponent<Controller>().enabled = true;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}

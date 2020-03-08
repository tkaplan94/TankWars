using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private static bool GameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
        // user hit Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // if game is already pause
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
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // Called when Resume() is selected from Pause Menu
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // Called when Quit is selected from Pause Menu
    public void Quit()
    {
        Application.Quit();
    }
}

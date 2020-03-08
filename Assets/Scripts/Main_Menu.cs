using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Called when Play is selected from Main Menu
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Called when Quit is selected from Main Menu
    public void Quit()
    {
        Application.Quit();
    }
}

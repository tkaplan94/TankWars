using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Menu : MonoBehaviour
{
    GameObject loadTanks;
    [SerializeField] private GameObject gameOverMenu;
    private string winningTeam;

    // Start is called before the first frame update
    void Start()
    {
        loadTanks = GameObject.Find("Load Tanks");
    }

    // Update is called once per frame
    void Update()
    {
        if (loadTanks.GetComponent<Load_Tanks>().GetNumOfActiveTeams() <= 1)
        {
            // if green tanks remain
            if (loadTanks.GetComponent<Load_Tanks>().GetNumOfActiveGreenTanks() >= 1)
            {
                winningTeam = "Green Team";
                Display();
            }
            // if red tanks remain
            else if (loadTanks.GetComponent<Load_Tanks>().GetNumOfActiveRedTanks() >= 1)
            {
                winningTeam = "Red Team";
                Display();
            }
            // if yellow tanks remain
            else if (loadTanks.GetComponent<Load_Tanks>().GetNumOfActiveYellowTanks() >= 1)
            {
                winningTeam = "Yellow Team";
                Display();
            }
        }
    }

    // Displays Game Over screen
    private void Display()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}

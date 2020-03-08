using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_Tanks : MonoBehaviour
{
    private GameObject gameSettings;
    
    [SerializeField] private GameObject greenTankPrefab;
    [SerializeField] private GameObject redTankPrefab;
    [SerializeField] private GameObject yellowTankPrefab;

    Vector3 positionG1 = new Vector3(-10f, 0.5f, -5f);
    Vector3 positionG2 = new Vector3(-15f, 0.5f, -5f);
    Vector3 positionG3 = new Vector3(-12.5f, 0.5f, -7f);
    Vector3 positionR1 = new Vector3(10f, 0.5f, -5f);
    Vector3 positionR2 = new Vector3(15f, 0.5f, -5f);
    Vector3 positionR3 = new Vector3(12.5f, 0.5f, -7f);
    Vector3 positionY1 = new Vector3(-2.5f, 0.5f, 5f);
    Vector3 positionY2 = new Vector3(2.5f, 0.5f, 5f);
    Vector3 positionY3 = new Vector3(0f, 0.5f, 7f);

    void Awake()
    {
        gameSettings = GameObject.Find("Game Settings");

        int teams = gameSettings.GetComponent<Settings>().GetNumOfTeams();
        int tanks = gameSettings.GetComponent<Settings>().GetNumOfTanks();
        if (teams == 2)
        {
            gameSettings.GetComponent<Settings>().initNumOfTanksInTeams(tanks, tanks, 0);
        }
        else
        {
            gameSettings.GetComponent<Settings>().initNumOfTanksInTeams(tanks, tanks, tanks);
        }
        Debug.Log("Number of teams: " + teams);

        // 2 teams
        if (gameSettings.GetComponent<Settings>().GetNumOfTeams() == 2)
        {
            // 2 tanks per team
            if (gameSettings.GetComponent<Settings>().GetNumOfTanks() == 2)
            {
                // Instantiate Green Team
                Instantiate(greenTankPrefab, positionG1, Quaternion.identity);
                Instantiate(greenTankPrefab, positionG2, Quaternion.identity);

                // Instantiate Red Team
                Instantiate(redTankPrefab, positionR1, Quaternion.identity);
                Instantiate(redTankPrefab, positionR2, Quaternion.identity);
            }
            // 3 tanks per team
            else
            {
                // Instantiate Green Team
                Instantiate(greenTankPrefab, positionG1, Quaternion.identity);
                Instantiate(greenTankPrefab, positionG2, Quaternion.identity);
                Instantiate(greenTankPrefab, positionG3, Quaternion.identity);

                // Instantiate Red Team
                Instantiate(redTankPrefab, positionR1, Quaternion.identity);
                Instantiate(redTankPrefab, positionR2, Quaternion.identity);
                Instantiate(redTankPrefab, positionR3, Quaternion.identity);
            }

        }
        // 3 teams
        else
        {
            // 2 tanks per team
            if (gameSettings.GetComponent<Settings>().GetNumOfTanks() == 2)
            {
                // Instantiate Green Team
                Instantiate(greenTankPrefab, positionG1, Quaternion.identity);
                Instantiate(greenTankPrefab, positionG2, Quaternion.identity);

                // Instantiate Red Team
                Instantiate(redTankPrefab, positionR1, Quaternion.identity);
                Instantiate(redTankPrefab, positionR2, Quaternion.identity);

                // Instantiate Yellow Team
                Instantiate(yellowTankPrefab, positionY1, Quaternion.identity);
                Instantiate(yellowTankPrefab, positionY2, Quaternion.identity);
            }
            // 3 tanks per team
            else
            {
                // Instantiate Green Team
                Instantiate(greenTankPrefab, positionG1, Quaternion.identity);
                Instantiate(greenTankPrefab, positionG2, Quaternion.identity);
                Instantiate(greenTankPrefab, positionG3, Quaternion.identity);

                // Instantiate Red Team
                Instantiate(redTankPrefab, positionR1, Quaternion.identity);
                Instantiate(redTankPrefab, positionR2, Quaternion.identity);
                Instantiate(redTankPrefab, positionR3, Quaternion.identity);

                // Instantiate Yellow Team
                Instantiate(yellowTankPrefab, positionY1, Quaternion.identity);
                Instantiate(yellowTankPrefab, positionY2, Quaternion.identity);
                Instantiate(yellowTankPrefab, positionY3, Quaternion.identity);
            }
        }
    }
}

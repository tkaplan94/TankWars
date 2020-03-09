using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_Tanks : MonoBehaviour
{
    [SerializeField] private GameObject greenTankPrefab;
    [SerializeField] private GameObject redTankPrefab;
    [SerializeField] private GameObject yellowTankPrefab;

    // preset locations for tanks
    private Vector3 positionG1 = new Vector3(-7.5f, 0.5f, -5f);
    private Vector3 positionG2 = new Vector3(-12.5f, 0.5f, -5f);
    private Vector3 positionG3 = new Vector3(-10f, 0.5f, -7f);
    private Vector3 positionR1 = new Vector3(7.5f, 0.5f, -5f);
    private Vector3 positionR2 = new Vector3(12.5f, 0.5f, -5f);
    private Vector3 positionR3 = new Vector3(10f, 0.5f, -7f);
    private Vector3 positionY1 = new Vector3(-2.5f, 0.5f, 5f);
    private Vector3 positionY2 = new Vector3(2.5f, 0.5f, 5f);
    private Vector3 positionY3 = new Vector3(0f, 0.5f, 7f);

    // used to determine when game is over
    private int numOfActiveTeams;
    private int numOfActiveGreenTanks;
    private int numOfActiveRedTanks;
    private int numOfActiveYellowTanks;

    // Instantiates tanks based on Game Settings
    void Awake()
    {
        GameObject gameSettings = GameObject.Find("Game Settings");
        numOfActiveTeams = gameSettings.GetComponent<Settings>().GetNumOfTeams();
        numOfActiveGreenTanks = gameSettings.GetComponent<Settings>().GetNumOfTanks();
        numOfActiveRedTanks = gameSettings.GetComponent<Settings>().GetNumOfTanks();
        numOfActiveYellowTanks = gameSettings.GetComponent<Settings>().GetNumOfTanks();

        // 2 teams
        if (numOfActiveTeams == 2)
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

    // decreases number of enemy tanks
    public void decrementTanks(string enemy)
    {
        switch (enemy)
        {
            case "PlayerG":
                numOfActiveGreenTanks--;
                if (numOfActiveGreenTanks == 0)
                {
                    numOfActiveTeams--;
                } 
                break;
            case "PlayerR":
                numOfActiveRedTanks--;
                if (numOfActiveRedTanks == 0)
                {
                    numOfActiveTeams--;
                }
                break;
            case "PlayerY":
                numOfActiveYellowTanks--;
                if (numOfActiveYellowTanks == 0)
                {
                    numOfActiveTeams--;
                }
                break;
        }
    }

    // Getter Function for numOfActiveTeams
    public int GetNumOfActiveTeams()
    {
        return numOfActiveTeams;
    }

    // Getter Function for numOfActiveGreenTanks
    public int GetNumOfActiveGreenTanks()
    {
        return numOfActiveGreenTanks;
    }

    // Getter Function for numOfActiveRedTanks
    public int GetNumOfActiveRedTanks()
    {
        return numOfActiveRedTanks;
    }

    // Getter Function for numOfActiveYellowTanks
    public int GetNumOfActiveYellowTanks()
    {
        return numOfActiveYellowTanks;
    }
}

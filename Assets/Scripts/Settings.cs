using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private int numOfTeams;
    [SerializeField] private int numOfTanks;

    private int numOfGreenTanks;
    private int numOfRedTanks;
    private int numOfYellowTanks;

    // Update is called once per frame
    void Update()
    {
        checkForGameOver();
    }

    // initialize number of tanks in each team
    public void initNumOfTanksInTeams(int g, int r, int y)
    {
        numOfGreenTanks = g;
        numOfRedTanks = r;
        numOfYellowTanks = y;
    }

    // decreases number of tanks on the field
    //  and check if team has been eliminated
    public void decrementTanks(string tagOfVictim)
    {
        switch (tagOfVictim)
        {
            case "PlayerG":
                numOfGreenTanks--;
                if (numOfGreenTanks <= 0)
                {
                    numOfTeams--;
                    Debug.Log("Number of teams left: " + numOfTeams);
                }
                break;
            case "PlayerR":
                numOfRedTanks--;
                if (numOfRedTanks <= 0)
                {
                    numOfTeams--;
                    Debug.Log("Number of teams left: " + numOfTeams);
                }
                break;
            case "PlayerY":
                numOfYellowTanks--;
                if (numOfYellowTanks <= 0)
                {
                    numOfTeams--;
                    Debug.Log("Number of teams left: " + numOfTeams);
                }
                break;
        }

    }

    // checks if game is over/won
    public void checkForGameOver()
    {
        if (numOfTeams <= 1)
        {
            Debug.Log("Game Over!!");
        }
    }

    // Setter Function for default values
    public void SetDefaultValues()
    {
        numOfTeams = 2;
        numOfTanks = 2;
    }

    // Setter Function for number of teams based on Settings Menu options
    public void SetNumOfTeams(int teamsIndex)
    {
        if (teamsIndex == 0)
        {
            numOfTeams = 2;
        }
        else
        {
            numOfTeams = 3;
        }
    }

    // Setter Function for number of tanks based on Settings Menu options
    public void SetNumOfTanks(int tanksIndex)
    {
        if (tanksIndex == 0)
        {
            numOfTanks = 2;
        }
        else
        {
            numOfTanks = 3;
        }
    }

    // Getter Function for number of teams to Instantiate
    public int GetNumOfTeams()
    {
        return numOfTeams;
    }

    // Getter Function for number of tanks to Instantiate
    public int GetNumOfTanks()
    {
        return numOfTanks;
    }

}

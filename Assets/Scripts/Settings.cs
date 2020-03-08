using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private int numOfTeams;
    [SerializeField] private int numOfTanks;

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

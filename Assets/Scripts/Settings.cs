using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private int numOfTeams;
    [SerializeField] private int numOfTanks;
    private int totalNumOfTanks;

    // Update is called once per frame
    void Start()
    {
        totalNumOfTanks = numOfTeams * numOfTanks;
        Debug.Log("Total number of tanks: " + totalNumOfTanks);
    }

    // decreases number of tanks on the field
    public void decrementTanks(string tag)
    {
        totalNumOfTanks--;
        Debug.Log("Total number of tanks: " + totalNumOfTanks);

        if (totalNumOfTanks == 1)
        {
            switch (tag)
            {
                case "BulletG":
                    Debug.Log("Green Team wins!!");
                    break;
                case "BulletR":
                    Debug.Log("Red Team wins!!");
                    break;
                case "BulletY":
                    Debug.Log("Yellow Team wins!!");
                    break;
            }
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

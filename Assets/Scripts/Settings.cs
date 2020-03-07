using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private int numOfTeams;
    [SerializeField] private int numOfTanks;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetNumOfTeams(int teams)
    {
        numOfTeams = teams;
    }

    public void SetNumOfTanks(int tanks)
    {
        numOfTanks = tanks;
    }
}

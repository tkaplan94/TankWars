using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private int numOfTeams;
    [SerializeField] private int numOfTanks;

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

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(greenTankPrefab, positionG1, Quaternion.identity);
        Instantiate(greenTankPrefab, positionG2, Quaternion.identity);
        Instantiate(greenTankPrefab, positionG3, Quaternion.identity);
        Instantiate(greenTankPrefab, positionR1, Quaternion.identity);
        Instantiate(greenTankPrefab, positionR2, Quaternion.identity);
        Instantiate(greenTankPrefab, positionR3, Quaternion.identity);
        Instantiate(greenTankPrefab, positionY1, Quaternion.identity);
        Instantiate(greenTankPrefab, positionY2, Quaternion.identity);
        Instantiate(greenTankPrefab, positionY3, Quaternion.identity);
    }
}

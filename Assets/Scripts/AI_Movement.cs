using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Movement : MonoBehaviour
{
    private string[] movement =  { "up", "down", "left", "right" };
    private string direction;

    [SerializeField] private int changeDirCooldown;
    private int changeDirTimer;

    // Start is called before the first frame update
    void Start()
    {
        changeDirTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (changeDirTimer == 0)
        {
            ChangeDirection();
            changeDirTimer = changeDirCooldown;
        }
        changeDirTimer--;
    }

    // ChangeDirection is called when it is time for the AI
    //  to pick a different direction for movement
    private void ChangeDirection()
    {
        direction = movement[Random.Range(0, movement.Length)];
    }

    // GetDirection returns the current direction chosen for movement
    public string GetDirection()
    {
        return direction;
    }

    // faces tank in opposite direction
    public void turnAround()
    {
        switch(direction)
        {
            case "up":
                direction = "down";
                break;
            case "down":
                direction = "up";
                break;
            case "left":
                direction = "right";
                break;
            case "right":
                direction = "left";
                break;
        }
    }

    // reset changeDirTimer
    public void resetChangeDirTimer()
    {
        changeDirTimer = changeDirCooldown;
    }
}

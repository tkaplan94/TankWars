using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public enum Direction { up, down, left, right };
    private Direction myDirection;

    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag == "PlayerG")
        {
            myDirection = Direction.up;
        }
        else if (this.gameObject.tag == "PlayerR")
        {
            myDirection = Direction.down;
        }
    }

    // Setter function for myDirection
    public void SetDirection(Direction direction)
    {
        myDirection = direction;
    }

    // Getter function for myDirection
    public Direction GetDirection()
    {
        return myDirection;
    }
}

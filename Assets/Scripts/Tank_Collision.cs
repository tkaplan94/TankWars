using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // tank collided with wall
        if (other.gameObject.tag == "Wall" ||
            other.gameObject.tag == this.gameObject.tag)
        {
            GetComponent<AI_Movement>().turnAround();
            GetComponent<AI_Movement>().resetChangeDirTimer();
        }
    }
}

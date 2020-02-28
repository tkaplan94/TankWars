using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collision : MonoBehaviour
{
    [SerializeField] private string enemy1;
    [SerializeField] private string enemy2;

    private void OnTriggerEnter(Collider other)
	{
        // if bullet collided with either enemy
        if (other.gameObject.tag == enemy1 || other.gameObject.tag == enemy2)
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
        // otherwise, destroy bullet no matter what it hit
        else if (other.gameObject)
        {
            Destroy(this.gameObject);
        }
    }	
}
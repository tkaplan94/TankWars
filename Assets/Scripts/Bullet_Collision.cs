using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collision : MonoBehaviour
{
    [SerializeField] private string enemyTag1;
    [SerializeField] private string enemyTag2;

    private void OnTriggerEnter(Collider other)
	{
        GameObject gameSettings = GameObject.Find("Game Settings");

        // if bullet collided with either enemy
        if (other.gameObject.tag == enemyTag1 || other.gameObject.tag == enemyTag2)
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
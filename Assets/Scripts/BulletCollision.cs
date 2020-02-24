using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
	
	public string enemy;
	public Rigidbody playerGPrefab;
	public Rigidbody playerRPrefab;
	public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Wall")
		{	
			Destroy(gameObject);
		}
		
		if (other.gameObject.tag == enemy)
		{
			Destroy(other.gameObject);
			if (enemy == "PlayerG")
			{
				Instantiate(playerGPrefab, new Vector3(-8.5f, 0.5f, -3.5f), new Quaternion(0, 0, 0, 0));
			}
			if (enemy == "PlayerR")
			{
				Instantiate(playerRPrefab, new Vector3(8.5f, 0.5f, 3.5f), new Quaternion(0, 180, 0, 0));
			}
			Destroy(gameObject);
		}
	}	
}
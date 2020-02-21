using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
	
	public string enemy;
	public Rigidbody player1prefab;
	public Rigidbody player2prefab;
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
			if (enemy == "Player1")
			{
				Instantiate(player1prefab, new Vector3(-8.72f, 2.24f, -6.17f), new Quaternion(0, 0, 0, 0));
			}
			if (enemy == "Player2")
			{
				Instantiate(player2prefab, new Vector3(8.46f, 2.24f, 1.12f), new Quaternion(0, 180, 0, 0));
			}
			Destroy(gameObject);
		}
	}	
}
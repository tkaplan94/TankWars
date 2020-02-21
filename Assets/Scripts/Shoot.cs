using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public Rigidbody prefab;
	public string key;
	public string key2;
	private Rigidbody tank;
	private double cooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        tank = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (cooldown <= Time.time)
		{
			if(Input.GetKey(key) || Input.GetKey(key2))
			{
				cooldown = Time.time + .25;
				Rigidbody projectile;
				
				Vector3 location = tank.transform.GetChild(0).position;
				
				projectile = Instantiate(prefab, location, tank.transform.rotation);
				projectile.velocity = transform.TransformDirection(Vector3.forward * 5);
			}
        }
    }
}

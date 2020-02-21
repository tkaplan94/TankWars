using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Right : MonoBehaviour
{
	
	private Rigidbody tank;
	public string key;
    // Start is called before the first frame update
    void Start()
    {
        tank = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		tank.velocity = Vector3.zero;
		tank.angularVelocity = Vector3.zero;
		
        if (Input.GetKey(key))
		{
			tank.transform.rotation = Quaternion.LookRotation(new Vector3(2.5f, 0.0f, 0.0f), Vector3.up);
			tank.AddForce(new Vector3(2.5f, 0.0f, 0.0f), ForceMode.VelocityChange);
		}		    
    }
}

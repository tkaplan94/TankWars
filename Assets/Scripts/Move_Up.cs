using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Up : MonoBehaviour
{
    private Rigidbody tank;

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
		
        if (GetComponent<AI_Movement>().GetDirection() == "up")
		{
			tank.transform.rotation = Quaternion.LookRotation(new Vector3(0.0f, 0.0f, 2.5f), Vector3.up);
			tank.AddForce(new Vector3(0.0f, 0.0f, 2.5f), ForceMode.VelocityChange);
		}		    
    }
}

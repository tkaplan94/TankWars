using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Down : MonoBehaviour
{
    [SerializeField] private string key;
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

        // if AI chose "down"
        if (Input.GetKey(key) || GetComponent<AI_Movement>().GetDirection() == "down")
		{
            GetComponent<Compass>().SetDirection(Compass.Direction.down);
            tank.transform.rotation = Quaternion.LookRotation(new Vector3(0.0f, 0.0f, -2.5f), Vector3.up);
			tank.AddForce(new Vector3(0.0f, 0.0f, -2.5f), ForceMode.VelocityChange);
		}		    
    }
}

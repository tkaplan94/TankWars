using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public Rigidbody bulletPrefab;
	private GameObject tank;
    private double cooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        tank = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
		if (cooldown <= Time.time)
		{
            // if AI chose to shoot
			if(GetComponent<AI_Shooting>().ShouldFire())
			{
				cooldown = Time.time + .25;
				Rigidbody projectile;
				Vector3 location = tank.transform.position;

                projectile = Instantiate(bulletPrefab, location, tank.transform.rotation);
                Physics.IgnoreCollision(projectile.GetComponent<Collider>(), GetComponent<Collider>());
                projectile.velocity = transform.TransformDirection(Vector3.forward * 5);
			}
        }
    }
}

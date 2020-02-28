using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Shooting : MonoBehaviour
{
    [SerializeField] private float visualRadius;
    [SerializeField] private string enemy1;
    [SerializeField] private string enemy2;

    private GameObject target;
    private bool shouldFire;

    // Start is called before the first frame update
    void Start()
    {
        target = null;
        shouldFire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetsInRadius())
        {
            if (targetsInPath())
            {
                shouldFire = true;
            }
            else
            {
                shouldFire = false;
            }
        }
    }

    // checkForTargets finds all enemies
    private bool targetsInRadius()
    {
        List<GameObject> targets = new List<GameObject>();
        GameObject[] tempTargets;
        
        // get both teams (arrays of targets) into one list
        tempTargets = GameObject.FindGameObjectsWithTag(enemy1);
        for (int i = 0; i < tempTargets.Length; i++)
        {
            targets.Add(tempTargets[i]);
        }
        tempTargets = GameObject.FindGameObjectsWithTag(enemy2);
        for (int i = 0; i < tempTargets.Length; i++)
        {
            targets.Add(tempTargets[i]);
        }

        // set shouldFire to true if any target is in radius
        for (int i = 0; i < targets.Count; i++)
        {
            float targetDist = Vector3.Distance(this.transform.position, targets[i].transform.position);

            if (targetDist <= visualRadius)
            {
                target = targets[i];
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }

    // CheckForTargetInPath sets shouldFire according to
    //  whether or not target is in path
    private bool targetsInPath()
    {
        if (!target)
        {
            return false;
        }
 
        float myZ = this.transform.position.z;
        float myX = this.transform.position.x;
        float targetZ = target.transform.position.z;
        float targetX = target.transform.position.x;

        // check for targets to the right
        if (targetX > myX)
        {
            // check for targets in horizontal path of fire
            if (targetZ <= myZ + 1.5 && targetZ >= myZ - 1.5)
            {
                // check if tank is facing right
                if (GetComponent<Compass>().GetDirection() == Compass.Direction.right)
                {
                    return true;
                }
            }
            // check for targets in vertical path of fire below
            else if (targetX < myX + 1.5 && targetZ < myZ)
            {
                // check if tank is facing down
                if (GetComponent<Compass>().GetDirection() == Compass.Direction.down)
                {
                    return true;
                }
            }
            // check for targets in vertical path of fire above
            else if (targetX < myX + 1.5 && targetZ > myZ)
            {
                // check if tank is facing up
                if (GetComponent<Compass>().GetDirection() == Compass.Direction.up)
                {
                    return true;
                }
            }
            // otherwise, not in any path of fire
            else
            {
                return false;
            }
        }
        // check for targets to the left
        else
        {
            // check for targets in horizontal path of fire
            if (targetZ <= myZ + 1.5 && targetZ >= myZ - 1.5)
            {
                // check if tank is facing left
                if (GetComponent<Compass>().GetDirection() == Compass.Direction.left)
                {
                    return true;
                }
            }
            // check for targets in vertical path of fire below
            else if (targetX > myX - 1.5 && targetZ < myZ)
            {
                // check if tank is facing down
                if (GetComponent<Compass>().GetDirection() == Compass.Direction.down)
                {
                    return true;
                }
            }
            // check for targets in vertical path of fire above
            else if (targetX > myX - 1.5 && targetZ > myZ)
            {
                // check if tank is facing up
                if (GetComponent<Compass>().GetDirection() == Compass.Direction.up)
                {
                    return true;
                }
            }
        }

        // otherwise, return false
        return false;
        
        //// check for targets to the right
        //if (targetX > myX)
        //{
        //    // check if target is facing proper direction
        //    if (GetComponent<Compass>().GetDirection() == Compass.Direction.right)
        //    {
        //        // check for targets in path give or take 2
        //        if (targetZ <= myZ + 1.5 && targetZ >= myZ - 1.5)
        //        {
        //            shouldFire = true;
        //        }
        //        else
        //        {
        //            shouldFire = false;
        //        }
        //    }
        //    else
        //    {
        //        shouldFire = false;
        //        return;
        //    }
        //}
        //// check for targets to the left
        //else if (targetX < myX)
        //{
        //    // check if target is facing proper direction
        //    if (GetComponent<Compass>().GetDirection() == Compass.Direction.left)
        //    {
        //        // check for targets in path give or take 2
        //        if (targetZ <= myZ + 1.5 && targetZ >= myZ - 1.5)
        //        {
        //            shouldFire = true;
        //        }
        //        else
        //        {
        //            shouldFire = false;
        //        }
        //    }
        //    else
        //    {
        //        shouldFire = false;
        //        return;
        //    }
        //}
        //// check for targets above
        //else if (targetZ > myZ)
        //{
        //    // check if target is facing proper direction
        //    if (GetComponent<Compass>().GetDirection() == Compass.Direction.up)
        //    {
        //        // check for targets in path give or take 2
        //        if (targetX <= myX + 1.5 && targetX >= myX - 1.5)
        //        {
        //            shouldFire = true;
        //        }
        //        else
        //        {
        //            shouldFire = false;
        //        }
        //    }
        //    else
        //    {
        //        shouldFire = false;
        //        return;
        //    }
        //}
        //// check for targets below
        //else if (targetZ < myZ)
        //{
        //    // check if target is facing proper direction
        //    if (GetComponent<Compass>().GetDirection() == Compass.Direction.down)
        //    {
        //        // check for targets in path give or take 2
        //        if (targetX <= myX + 1.5 && targetX >= myX - 1.5)
        //        {
        //            shouldFire = true;
        //        }
        //        else
        //        {
        //            shouldFire = false;
        //        }
        //    }
        //    else
        //    {
        //        shouldFire = false;
        //        return;
        //    }
        //}
    }

    // Getter function for shouldFire
    public bool ShouldFire()
    {
        return shouldFire;
    }
}

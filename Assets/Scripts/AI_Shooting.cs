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
            CheckForTargetInPath();
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
    private void CheckForTargetInPath()
    {
        if (target == null)
        {
            shouldFire = false;
            return;
        }
 
        float myZ = this.transform.position.z;
        float myX = this.transform.position.x;
        float targetZ = target.transform.position.z;
        float targetX = target.transform.position.x;

        // check for targets to the right
        if (targetX > myX)
        {
            // check for targets in path give or take 2
            if (targetZ <= myZ + 2 && targetZ >= myZ - 2)
            {
                shouldFire = true;
                return;
            }
            else
            {
                shouldFire = false;
                return;
            }
        }
        // check for targets to the left
        else if (targetX < myX)
        {
            // check for targets in path give or take 2
            if (targetZ <= myZ + 2 && targetZ >= myZ - 2)
            {
                shouldFire = true;
                return;
            }
            else
            {
                shouldFire = false;
                return;
            }
        }
        // check for targets above
        else if (targetZ > myZ)
        {
            // check for targets in path give or take 2
            if (targetX <= myX + 2 && targetX >= myX - 2)
            {
                shouldFire = true;
                return;
            }
            else
            {
                shouldFire = false;
                return;
            }
        }
        // check for targets below
        else if (targetZ < myZ)
        {
            // check for targets in path give or take 2
            if (targetX <= myX + 2 && targetX >= myX - 2)
            {
                shouldFire = true;
                return;
            }
            else
            {
                shouldFire = false;
                return;
            }
        }
        else
        {
            shouldFire = false;
            return;
        }
    }

    // Getter function for shouldFire
    public bool ShouldFire()
    {
        return shouldFire;
    }
}

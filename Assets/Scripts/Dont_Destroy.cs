using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_Destroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}

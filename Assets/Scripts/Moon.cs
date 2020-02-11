using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public static bool moonWalk;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        moonWalk = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        moonWalk = false;
    }
}

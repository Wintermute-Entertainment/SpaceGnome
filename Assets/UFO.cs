using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    public static bool uFO_Collided;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        uFO_Collided = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        uFO_Collided = false;
    }
}

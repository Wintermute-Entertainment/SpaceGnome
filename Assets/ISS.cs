using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISS : MonoBehaviour
{

    public static bool iSS_Collided;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        iSS_Collided = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        iSS_Collided = false;
    }
}

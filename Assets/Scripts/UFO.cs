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
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            uFO_Collided = true;
        }
        
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            uFO_Collided = false;
        }
        
    }
}

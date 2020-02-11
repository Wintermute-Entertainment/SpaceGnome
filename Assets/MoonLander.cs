using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonLander : MonoBehaviour
{
    public static bool moonLanderCollided;
    public void OnCollisionEnter(Collision collision)
    {
        moonLanderCollided = true;
    }
    public void OnCollisionExit(Collision collision)
    {
        moonLanderCollided = false;
    }
}

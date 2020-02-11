using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatDish : MonoBehaviour
{
    public static bool satDishCollided;
    public void OnCollisionEnter(Collision collision)
    {
        satDishCollided = true;
    }
    public void OnCollisionExit(Collision collision)
    {
        satDishCollided = false;
    }
}

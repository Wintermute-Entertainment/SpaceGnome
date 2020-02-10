using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerFinished : MonoBehaviour
{
public void OnCollisionEnter(Collision collider)
    {
        
        if (collider.gameObject.name=="EarthJumpEarth")
        {
            GameObject.Find("EarthJumpGnome1").SendMessage("TimerStop");
        }
            

        
    }
}

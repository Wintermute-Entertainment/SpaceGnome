using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenPowerUp : MonoBehaviour
{
   
    void Start()
    {
        Timer.t += 30f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            GameObject.Find("EarthJumpGnome1").SendMessage("OxygenPowerUp");
            
            Destroy(gameObject);
        }

        
        
    }
    
}

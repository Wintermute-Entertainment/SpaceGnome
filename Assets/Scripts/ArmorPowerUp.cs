using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPowerUp : MonoBehaviour
{
   
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
            AddPlayerHealth();

            Destroy(gameObject);
        }

        
        
    }
    public void AddPlayerHealth()
    {
        PlayerHealth.currentHealth += 1f;
    }
}

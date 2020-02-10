using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{

    public GameObject smoke;
    public GameObject fire;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.currentHealth <= 15)
        {
            smoke.SetActive(true);
        }
        else
        {
            smoke.SetActive(false);
        }
        if (PlayerHealth.currentHealth <= 10)
        {
            fire.SetActive(true);
        }
        else
        {
            fire.SetActive(false);
        }
        if (PlayerHealth.currentHealth <= 5)
        {
            explosion.SetActive(true);
        }
        else
        {
            explosion.SetActive(false);
        }

    }
}

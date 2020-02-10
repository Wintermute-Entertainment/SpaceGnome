using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenTimer : MonoBehaviour
{

    public float timeLeft;

    private void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft < 0)
        {
            //PlayerHealth.GameOver();
        }
    }
}

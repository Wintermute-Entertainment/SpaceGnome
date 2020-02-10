using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;

    public static bool timerFinished = false;
    //public bool timerPaused = false;

    public GameObject gameOverPanel; // Game Over output.
    public GameObject earthPanel;
    public GameObject losePanel;

    public static float remainingMinutes;
    public static float remainingSeconds;

    public float t;

    

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time + 120; //Time in seconds to count down from.
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (!timerPaused) // Timer pause condition for level pass (successfully or not, just without dying).
        //{
        //    t+= Time.deltaTime;
        //}
        if (timerFinished)      //Game over condition when timer runs out.
            return;

        t = Time.time - startTime; //Time variable.
        
        string minutes = ((int) t / 60).ToString();  //Minutes string.
        string seconds = (-t % 60).ToString(format:"f1"); //Seconds string to one decimal place.

        remainingMinutes = t + startTime + Time.time / 60;
        remainingSeconds = t + startTime + Time.time;

        timerText.text = minutes + ":" + seconds; //Text object output.

        if (t >= 0)                 //Timer stop and Game Over condition.
        {
            TimerStop();
            if (!earthPanel.activeSelf == true || !losePanel.activeSelf == true)
            {
                GameOver();
            }
            
        }


    //Could also Stop timer with a collider with "IsTrigger" checked by attaching following code in a separate script to the GO with the collider on it.

    /*
    public void OnTriggerEnter(Collider other)
    {
    GameObject.Find("EarthJumpGnome1").SendMessage("TimerStop");
    }*/

    }

public void TimerStop()
{
timerText.color = Color.magenta;
timerFinished = true;

}
    //public void TimerPause()
    //{
    //    timerText.color = Color.cyan;
    //    timerPaused = true;
    //    Time.
    //}
public void GameOver()
{
gameOverPanel.SetActive(true);
Destroy(gameObject);
}
                            
public void OxygenPowerUp()
{
      startTime += 30;
Debug.Log("Picked up O2.");
}

private void OnCollisionEnter(Collision collision)
{
if (collision.gameObject.tag == "OxygenPowerUp")
{
    OxygenPowerUp();

    //Destroy(collision.gameObject);
}

if (collision.gameObject.name == "EarthJumpEarth")
        {
            TimerStop();
        }

}
}

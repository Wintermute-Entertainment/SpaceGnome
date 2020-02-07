using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static float points = 0.0f;
    public Animator myAnimator;

    public static float currentPoints;

    public static float boost;

    public bool winPanelActive;
    public bool losePanelActive;

    public GameObject winPanel;
    public GameObject losePanel;

    public Text pointsText;
    public Text boostText;
    public Text armourText;
    public Text debugLogText;
    public Text finalScoreText;
    public Text finalScoreLossText;
    public Text finalScoreDeathText;

    public static float finalScore;

    void Start()
    {
        boost = 5000f;
        //points = 2000f;
        
    }
    void Update()
    {
        CurrentPoints();

        
        pointsText.text = points.ToString();
        boostText.text = boost.ToString();
        armourText.text = PlayerHealth.currentHealth.ToString();
        finalScoreText.text = finalScore.ToString();
        finalScoreLossText.text = finalScore.ToString();
        finalScoreDeathText.text = finalScore.ToString();

        if (PlayerHealth.dead==true)
            {
            print("Final Score at death: " + finalScore);
            }
        if (winPanelActive)
        {
            print("Final Score on win: " + finalScore);
        }
        if (losePanelActive)
        {
            print("Final score on lose: " + finalScore);
        }
        
        //Multiplier x2 for first successive easy move and hard move (SHIFT move + CTRL+SHIFT move), x4 for next easy+hard move, etc.
        print(points + " points.");
    }

    private void FixedUpdate()
    {
        if (Points.boost >= 0)
        {


            if (myAnimator.GetBool("frontFlip"))
            {
                points += 10f;
                boost -= 5f;
            }
            if (myAnimator.GetBool("backFlip"))
            {
                points += 10f;
                boost -= 5f;
            }
            if (myAnimator.GetBool("leftRoll"))
            {
                points += 10f;
                boost -= 5f;
            }
            if (myAnimator.GetBool("rightRoll"))
            {
                points += 10f;
                boost -= 5f;
            }
            if (myAnimator.GetBool("headSpin"))
            {
                points += 20f;
                boost -= 10f;
            }
            if (myAnimator.GetBool("Jumping"))
            {
                points += 20f;
                boost -= 10f;
            }
            if (myAnimator.GetBool("walkForward"))
            {
                //points += 5f;
                boost += 10f;
            }
            if (myAnimator.GetBool("noseDive"))
            {
                boost -= 10f;
            }
            if (myAnimator.GetBool("floatUp"))
            {
                boost -= 10f;
            }
            if (myAnimator.GetBool("cartWheel"))
            {
                boost += 10f;
            }
            if (myAnimator.GetBool("cartWheelRight"))
            {
                boost += 10f;
            }
            if (myAnimator.GetBool("walkBack"))
            {
                boost += 10f;
            }
            else if (myAnimator.GetBool("walkForward"))
            {
                points += 10f;
                boost -= 10f;
            }
            else if (myAnimator.GetBool("spinRight"))
            {
                points += 20f;
                boost -= 10f;
            }
            else if (myAnimator.GetBool("spinForward"))
            {
                points += 20f;
                boost -= 10f;
            }
            else if (myAnimator.GetBool("spinBack"))
            {
                points += 20f;
                boost -= 10f;
            }

            else if (myAnimator.GetBool("isFallingIdle"))
            {
                //boost += 5f;
                boost -= 1f;
            }
            

            if (UFO.uFO_Collided)
            {
                Debug.Log("UFO BOOST!!!");
                boost += 20f;
                points += 20f;
                if (myAnimator.GetBool("headSpin"))
                {
                    Debug.Log("Head Spin on the UFO!!!");
                    boost += 30f;
                    points += 30f;
                }
            }
            if (ISS.iSS_Collided)
            {
                Debug.Log("ISS BOOST!!!");
                boost += 10f;
                points += 10f;
                if (myAnimator.GetBool("walkForward") || (myAnimator.GetBool("walkBack") || (myAnimator.GetBool("cartWheel") || (myAnimator.GetBool("cartWheelRight")))))
                {
                    Debug.Log("DANCING ON THE ISS!");
                    boost += 20f;
                    points += 20f;
                }
            }
            if (Moon.moonWalk)
            {
                Debug.Log("MOON BOOST!!!");
                boost += 15f;
                points += 15f;
                if (myAnimator.GetBool("walkBack"))
                {
                    Debug.Log("MOONWALKING ON THE MOON!!!");
                    boost += 30f;
                    points += 30f;
                }
            }

        }
    }
    private void LateUpdate()
    {
        FinalScore();
        if (winPanelActive == true)
        {
            losePanelActive = false;
        }
        else if (winPanelActive==false)
        {
            losePanelActive = true;
        }
    }
    public void FinalScore()
    {
        //if (PlayerHealth.dead == true)
        //{
        //    finalScore = PlayerHealth.totalPoints +boost * Timer.t;
        //}
     
        finalScore = PlayerHealth.totalPoints * boost + (Timer.remainingMinutes + Timer.remainingSeconds); //Tempory additional code for testing without condition.
    }
    void OnGUI()
    {
        GUI.Label(new Rect(0, -10, 100, 100), finalScore.ToString());
        //GUI.Label(new Rect(0, 0, 90, 90), currentPoints.ToString());
    }
    public void CurrentPoints()
    {
        float currentPoints = points;
        print(currentPoints);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Earth")
        {
            if (points >= 25000)
            {
                //GameObject.Find("EarthJumpGnome1").SendMessage("TimerStop");
                
                winPanel.SetActive(true);
                winPanelActive = true;
                GameObject.Find("EarthJumpGnome1").SendMessage("GameOver");
                FinalScore();

            }
            else if (points < 25000)
            {
                //GameObject.Find("EarthJumpGnome1").SendMessage("TimerStop");
               
                losePanel.SetActive(true);
                losePanelActive = true;
                GameObject.Find("EarthJumpGnome1").SendMessage("GameOver");
                FinalScore();
            }   
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleNavigation : MonoBehaviour
{
    public GameObject shuttle;
    private bool flewToMercury;
    private bool flewToVenus;
    private bool flewToEarth;
    private bool flewToMars;

    private Vector3 currentPos;
    private Vector3 startPos;
    

    public GameObject navigationUI;

    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;
    public GameObject Pluto;

    private Vector3 mercuryPos;
    private Vector3 venusPos;
    private Vector3 earthPos;
    private Vector3 marsPos;


    private void Awake()
    {
        mercuryPos = Mercury.transform.position;
        venusPos = Venus.transform.position;
        earthPos = Earth.transform.position;
        marsPos = Mars.transform.position;

        //startPos = shuttle.transform.position;

    }
    public void Start()
    {
        //startPos = shuttle.transform.position;
    }
    private void Update()
    {
      //shuttle.transform.position = currentPos;

        if (flewToMercury)
        {
            currentPos = mercuryPos;
           // flewToMercury = false;
        }
        if (flewToVenus)
        {
            currentPos = venusPos;
          //  flewToVenus = false;
        }
        if (flewToEarth)
        {
            currentPos = earthPos;
          //  flewToEarth = false;
        }
        if (flewToMars)
        {
            currentPos = marsPos;
          //  flewToMars = false;
        }
        //else
        //{
        //    currentPos = startPos;
        //}
    }
    private void LateUpdate()
    {
       
        
           // ResetFlight();
        
    }

    public void FlytoMercury()
    {

        
        //shuttle.transform.position = new Vector3(Mercury.transform.position.x, Mercury.transform.position.y);
        flewToMercury = true;
        //mercuryPos = shuttle.transform.position;

    }
    public void FlytoVenus()
    {
        //shuttle.transform.position = new Vector3(Venus.transform.position.x, Venus.transform.position.y);
        flewToVenus = true;
        //currentPos = shuttle.transform.position;
    }
    public void FlytoEarth()
    {
        //shuttle.transform.position = Earth.transform.position;
        flewToEarth = true;
    }
    public void FlytoMars()
    {
        //shuttle.transform.position = Mars.transform.position;
        flewToMars = true;
    }
    public void FlytoJupiter()
    {
        shuttle.transform.position = Jupiter.transform.position;
    }
    public void FlytoSaturn()
    {
        shuttle.transform.position = Saturn.transform.position;
    }
    public void FlytoUranus()
    {
        shuttle.transform.position = Uranus.transform.position;
    }
    public void FlytoNeptune()
    {
        shuttle.transform.position = Neptune.transform.position;
    }
    public void FlytoPluto()
    {
        shuttle.transform.position = new Vector3 (Pluto.transform.position.x, Pluto.transform.position.y);
    }
   public void ResetFlight()
    {
        flewToEarth = false;
        flewToMars = false;
        flewToMercury = false;
        flewToVenus = false;

        //shuttle.transform.position = startPos;
    }

}

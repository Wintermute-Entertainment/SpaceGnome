using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdown : MonoBehaviour
{
    public GameObject Shuttle;
    public Rigidbody shuttleRB;

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

    //public Camera Main;
    //public Camera Front;
    //public Camera Top;

    //public Vector3 currentShuttlePos = Shuttle.transform.position;

    public void Start()
    {
        //shuttleRB = GetComponent<Rigidbody>();
    }
    private void Update()
    {
               
      //  transform.position = currentShuttlePos;
        //FlytoEarth();
        //FlytoJupiter();
        //FlytoMars();
        //FlytoMars();
        //currentShuttlePos = Shuttle.transform.position;
        //gameObject.transform.position = currentShuttlePos;
    }
    //{
    //    if (Front)
    //    {
    //        navigationUI.SetActive(true);
    //    }
    //    else
    //    {
    //        navigationUI.SetActive(false);
    //    }

    //    currentShuttlePos = Shuttle.transform.position;

    //}

    //public void ShuttlePosUpdate()
    //{
    //    Shuttle.transform.position = currentShuttlePos;
    //}

    public void FlytoMercury()
    {

        //Vector3.MoveTowards(transform.position, Mercury.transform.position, 10);
        //transform.Translate (transform.position + Mercury.transform.position);
        //currentShuttlePos = transform.position;
        Shuttle.transform.position = Mercury.transform.position;
        //shuttleRB.MovePosition(transform.position + Mercury.transform.position);
        //transform.Translate(Vector3.forward + Mercury.transform.position * Time.deltaTime, Space.World);


    }
    public void FlytoVenus()
    {
        Shuttle.transform.position = Venus.transform.position;
    }
    public void FlytoEarth()
    {
        Shuttle.transform.position = Earth.transform.position;
    }
    public void FlytoMars()
    {
        Shuttle.transform.position = Mars.transform.position;
    }
    public void FlytoJupiter()
    {
        Shuttle.transform.position = Jupiter.transform.position;
    }
    public void FlytoSaturn()
    {
        Shuttle.transform.position = Saturn.transform.position;
    }
    public void FlytoUranus()
    {
        Shuttle.transform.position = Uranus.transform.position;
    }
    public void FlytoNeptune()
    {
        Shuttle.transform.position = Neptune.transform.position;
    }
    public void FlytoPluto()
    {
        Shuttle.transform.position = Pluto.transform.position;
    }
   

}

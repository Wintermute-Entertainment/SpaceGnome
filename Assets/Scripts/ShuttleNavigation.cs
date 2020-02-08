using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleNavigation : MonoBehaviour
{
    public GameObject shuttle;
    //public Rigidbody shuttleRB;

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

    //public Vector3 currentShuttlePos = shuttle.transform.position;

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
        shuttle.transform.position = new Vector3(Mercury.transform.position.x, Mercury.transform.position.y);
        //shuttleRB.MovePosition(transform.position + Mercury.transform.position);
        //transform.Translate(Vector3.forward + Mercury.transform.position * Time.deltaTime, Space.World);


    }
    public void FlytoVenus()
    {
         
        shuttle.transform.position = Venus.transform.position;
    }
    public void FlytoEarth()
    {
        shuttle.transform.position = Earth.transform.position;
    }
    public void FlytoMars()
    {
        shuttle.transform.position = Mars.transform.position;
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
   

}

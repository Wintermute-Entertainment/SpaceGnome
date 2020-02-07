using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShuttle : MonoBehaviour
{
    public GameObject target;
    public float maxDistance;
    public float minDistance;

    public Quaternion maxRotation;
    //public Camera cam = Camera.main;
    //Vector3 camInitialPos;  //= Camera.main.transform.position;

    // Start is called before the first frame update
    void Start()
    {
        //camInitialPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);

        float distanceFromShuttle = Vector3.Distance(transform.position, target.transform.position);

        if (distanceFromShuttle > maxDistance)
        {
            transform.position = target.transform.position + (transform.position - target.transform.position).normalized * maxDistance;
        }

        if (distanceFromShuttle < minDistance)
        {
            transform.position = target.transform.position + (transform.position + target.transform.position).normalized * maxDistance;
        }

        //maxRotation = new Quaternion(45, 45, 45, 45);

        ////if (Input.GetKey(KeyCode.A) ||  (Input.GetKey(KeyCode.D)))
        ////  {
        ////    transform.RotateAround(transform.position, Vector3.up, 45 * Time.deltaTime);
        ////  }
        ////Vector3.RotateTowards(cam.transform.position, target.transform.position, 0,0);

        //Quaternion currentRotation = transform.rotation;

        //if (currentRotation == maxRotation)
        //{
        //    gameObject.transform.position = camInitialPos;
        //}

    }
}

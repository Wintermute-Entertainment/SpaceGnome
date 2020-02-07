using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameEngine gameEngine;

    public float anglePerUpdate = 0;

    //public Vector3 relativeRotatePos;
    public float revolutionsPerYear = 1f;

    public GameObject gravityAnchor;
    Vector3 lastKnownPosition;

    public GameObject objectRotated;
    //public Vector3 rotateAnchorPos;

    Vector3 initialPos;
    Quaternion initialRot;


    //public GameObject gravityCore;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameEngineObject =  GameObject.Find("GameEngine"); //returns found GO.
        //gameEngine = gameEngineObject.GetComponent< GameEngine >(); //return component .
        initialPos = gameObject.transform.position - gravityAnchor.transform.position;
        initialRot = gameObject.transform.rotation;
        lastKnownPosition = gameEngine.transform.position - gravityAnchor.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gravityAnchor != null)
        {
            gameObject.transform.position = gravityAnchor.transform.position + initialPos;
            gameObject.transform.rotation = initialRot;

            float yearRatio = gameEngine.totalTime / 31557600;

            gameObject.transform.RotateAround(gravityAnchor.transform.position, new Vector3(0, 1, 0), 360 * revolutionsPerYear * yearRatio); //When axis added (second paramter), rotates AROUND at given angle.
        }
        //gameObject.transform.rotation; //gameObject Always refers to GO script is on.
        //Quaternion holds rotation.

        //gameObject.transform.position = gravityAnchor.transform.position + initialPos;
        
        

        
        //gameObject.transform.Rotate(gameObject.transform.up);
    }
}

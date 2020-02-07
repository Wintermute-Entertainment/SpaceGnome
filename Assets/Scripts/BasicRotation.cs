using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRotation : MonoBehaviour
{

    public float xAngle, yAngle, zAngle;
    public GameObject object1, object2;

    void Awake()
    {
        //object1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        object1.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        //object1.name = "Self";

        //object2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        object2.transform.position = new Vector3(-0.75f, 0.0f, 0.0f);
        //object2.name = "World";
    }

    // Update is called once per frame
    void Update()
    {
        object1.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
        object2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);

        transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);

    }

    
}

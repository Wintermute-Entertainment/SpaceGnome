using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCubes : MonoBehaviour
{

    public GameObject cubesPrefab;
    public GameObject parentCubes;
    public GameObject newCubeInstantiator;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Cube Instantiator" + other.ToString());
        Instantiate(cubesPrefab, gameObject.transform.position- new Vector3(0,50,0), new Quaternion(0, 0, 0, 0));

       //Instantiate(newCubeInstantiator, (gameObject.transform.position + newCubeInstantiator.gameObject.transform.position),
                     //           gameObject.transform.rotation);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstanstiator : MonoBehaviour
{
    //public GameObject gameObject;
    public GameObject[] gameObjects;
    public bool objectInstantiated;
    public bool playerCollision = false;

    public GameObject player;
    private GameObject instantiatedObject;

    public GameObject objectInstantiator;

    public int objectCount;
    void Start()
    {
        objectInstantiated = false;
    }


    //private void Awake()
    //{
    //    GameObject clone = (GameObject)Instantiate(gameObject, transform.position, Quaternion.identity);
    //    Destroy(clone, 1.0f);
    //}
    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < gameObjects.Length; i++)
        //{
        //    InstantiateObject();
        //}

        if (playerCollision == true)
        {
            InstantiateObject();
        }
        //for (int i = 0; i >= objectCount; i++)
        //{
        //    Destroy(instantiatedObject);
        //}
        //if (playerCollision == true)
        //{
        //    InstantiateObject();
        //}
        if (objectCount >= 50)
        {
            Destroy(instantiatedObject);
        }
        //if (objectInstantiated)
        //{
        //    new WaitForSecondsRealtime(5);

        //    objectInstantiated = false;
        //}


        //if (!objectInstantiated)
        //{
        //    InstantiateObject();
        //}


    }
    private void FixedUpdate()
    {

    }

    void InstantiateObject()
    {
       
          
                GameObject instantiatedObject = Instantiate(gameObjects[Random.Range(0, gameObjects.Length)], (player.transform.position - new Vector3(Random.Range(0,20),(Random.Range(20,50)), 0)), Quaternion.identity);
                objectCount += 1;
                
                
           
        //Destroy(instantiatedObject);
        Destroy(gameObject);

        //Instantiate(objectInstantiator, (player.transform.position - new Vector3(0, (Random.Range(50, 100)), 0)), Quaternion.identity);
        
        Debug.Log("Object Instantaited:" + instantiatedObject);
        
        //Instantiate(gameObject, player.transform.position - new Vector3(0, 20, 0), Quaternion.identity);

        // Instantiate(gameObjects[Random.Range(0, gameObjects.Length)], (player.transform.position - new Vector3(0, 20, 0)), Quaternion.identity);

        //GameObject clone = (GameObject)(gameObjects[0]);
        //GameObject clone2 = (GameObject)(gameObjects[1]);
        //GameObject clone3 = (GameObject)(gameObjects[2]);

       

        //objectInstantiated = true;


        //new WaitForSecondsRealtime(3);

        //Destroy(clone);
        //Destroy(clone2);
        //Destroy(clone3);

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerCollision = true;
            
        }
    }

}
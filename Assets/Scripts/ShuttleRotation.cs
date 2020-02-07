using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]

public class ShuttleRotation : MonoBehaviour
{
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    public float zAxisSpeed = 2.0F;
    public GameObject GO;

    public Transform curPosition;

    
    
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //float z = zAxisSpeed * Input.GetAxis("zAxis");
        transform.Rotate(v, h, 0);

        RotateShuttle();
    }

    private void RotateShuttle()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GO.transform.Rotate(1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GO.transform.Rotate(-1, 0, 0);
        }
    }

    //void OnMouseDrag()
    //{
    //    float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    //    transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));
      
    //}
}


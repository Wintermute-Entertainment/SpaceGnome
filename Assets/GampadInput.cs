using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GampadInput : MonoBehaviour
{
    public PS4PlayerMovement controls;
    private Animator myAnimator;
    private Vector3 moveDirection;

    public float speed = 5f;

    public Vector3 movement;

    private void Awake()
    {
        controls = new PS4PlayerMovement();
        myAnimator = GetComponent<Animator>();
        controls.Player.Movement.performed += context => Move();
        
    }
    public void Update()
    {
        Move();
    }

public void Move()
    {
        Vector3 moveDirection = new Vector3(movement.x, movement.y, movement.z);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

}

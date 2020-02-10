using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GampadInput : MonoBehaviour
{
    public PS4PlayerMovement controls;
    private Animator myAnimator;
    private Vector3 moveDirection;

    public float speed = 5f;

    private void Awake()
    {
        //controls.Player.StartFlip.performed += context => StartFlip();
        //controls.Player.Movement.performed += context => MoveCharacter(context.ReadValue<Vector3>());


    }

    public void Update()
    {
        MoveCharacter(direction: moveDirection);
    }
    public void StartFlip()
    {
        
        myAnimator.SetBool("frontFlip", true);


    }
    void Flip()
    {

        if (!Input.GetButton("Fire3"))
        {
            StopFlip();
        }

    }
    void StopFlip()
    {
        myAnimator.SetBool("frontFlip", false);

    }

    public void MoveCharacter(Vector3 direction)
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float zAxis = Input.GetAxis("ZAxis");

        //float horizontal = movementInput.x;
        //float vertical = movementInput.y;
        //float zAxis = movementInput.z;

        //verticalInput = vertical;
        //horizontalInput = horizontal;
        //zAxisInput = zAxis;

        Vector3 moveDirection = new Vector3(horizontal, vertical, zAxis);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

}

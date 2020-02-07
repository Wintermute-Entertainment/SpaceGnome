using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //BASIC VARIABLES

    [SerializeField] private float speed = 5f; //Base movement speed.

    //BASIC REFERENCES
    public Transform myTransform; //This object's transform component (used for optimization).
    static public Rigidbody playerRigidbody;
    public Collider playerCollider; //Player Collider.

    //CAMERA REFERENCES
    public Transform mainCameraTransform;
    public Camera mainCamera; //Main Camera.

    //ANIMATION REFERENCES

    public Animator myAnimator; //Animator Controller.
    private AnimatorStateInfo myAnimatorStateInfo;// ???

    //PARTICLE SYSTEMS
    public ParticleSystem hitParticles;

    //MOVEMENT VARIABLES

    private float myYVelocity = 0.0f; //Current Y speed of the avatar.
    public float turnSpeed = 20f;
    public float jumpSpeed = 30.0f;

    bool isIdle;
    bool isFallingIdle;

    //Gravity
    private float gravity = -9.81f;

    //Velocity
    public float terminalYVelocity = -9f; //Meters per seconds.
    public float myDefaultYVelocity = -1.0f; //Default Y speed when the character is grounded.

    ///Jump
    public float jumpYVelocity = 3f; //Initial Jump speed.
    public float jumpCancelYVelocity = 6f; //Speed to  which the jump can be cancelled.


    private Vector3 moveDirection = Vector3.zero;
    public void Awake()
    {
        mainCamera = Camera.main;
        myAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float zAxis = Input.GetAxis("zAxis");

        //PLAYER INPUT

        if (Input.GetButton("Jump"))
        {
            StartJump();
        }
    }
    void FixedUpdate()
    {
        ApplyGravity();
        MoveCharacter();
        RotateCharacter();

    }
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject)
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Hit:" + collision.gameObject.name);
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Cube")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log(collision);
            isFallingIdle = false;
            isIdle = true;
            StartIdle();
        }

    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            isIdle = false;
            isFallingIdle = true;
            StartFallingIdle();
        }
    }

    //RESET STATES

    void ResetStates()
    {

        StopBackFlip();
        StopFlip();
        StopLeftRoll();
        StopRightRoll();
        StopJump();
        StopFallingIdle();
        StopIdle();
    }

    //STATE FUNCTIONS

    //FALLING IDLE

    void StartFallingIdle()
    {
        ResetStates();
        myAnimator.SetBool("isFallingIdle", true);
        FallingIdle();
    }
    void FallingIdle()
    {
        myAnimator.SetBool("isFallingIdle", true);

        if (isFallingIdle == false)
        {
            StopFallingIdle();
        }
    }
    void StopFallingIdle()
    {
        myAnimator.SetBool("isFallingIdle", false);

    }

    //STANDING IDLE

    void StartIdle()
    {
        ResetStates();

        myAnimator.SetBool("standingIdle", true);
        Idle();
    }
    void Idle()
    {

        myAnimator.SetBool("standingIdle", true);

        if (isIdle == false)
        {
            StopIdle();
        }


    }
    void StopIdle()
    {
        myAnimator.SetBool("standingIdle", false);
    }
    //JUMPING
    void StartJump()
    {
        ResetStates();
        myAnimator.SetBool("Jumping", true);
        Jump();
        //myYVelocity = jumpYVelocity;


    }

    void Jump()
    {
        myAnimator.SetBool("Jumping", true);

        if (!Input.GetButton("Jump")) //Cancel the jump momentum if the jump button is released.
        {
            //myYVelocity = jumpCancelYVelocity;
            StopJump();
        }
        //if (myYVelocity >= jumpCancelYVelocity) //Cancel the jump momentum if the Player's Yspeed exceeds YCancel velocity.
        //{
        //    StopJump();
        //}
    }
    void StopJump()
    {
        myAnimator.SetBool("Jumping", false);
    }

    //FLIPPING

    public void StartFlip()
    {
        ResetStates();
        myAnimator.SetBool("frontFlip", true);


    }
    void Flip()
    {
        myAnimator.SetBool("frontFlip", true);
        if (!Input.GetButtonUp("Fire3"))
        {
            StopFlip();
        }

    }
    void StopFlip()
    {
        myAnimator.SetBool("frontFlip", false);
    }
    //BACKFLIPPING
    public void StartBackFlip()
    {
        ResetStates();
        myAnimator.SetBool("backFlip", true);


    }
    void BackFlip()
    {
        myAnimator.SetBool("backFlip", true);
        if (!Input.GetButton("Fire3"))
        {
            StopBackFlip();
        }

    }
    void StopBackFlip()
    {
        myAnimator.SetBool("backFlip", false);
    }
    //LEFT ROLL
    public void StartLeftRoll()
    {
        ResetStates();
        myAnimator.SetBool("leftRoll", true);
        LeftRoll();

    }
    void LeftRoll()
    {
        myAnimator.SetBool("leftRoll", true);
        if (!Input.GetButtonDown("Fire3"))
        {
            StopLeftRoll();
        }

    }
    void StopLeftRoll()
    {
        myAnimator.SetBool("leftRoll", false);
    }

    //RIGHT ROLL
    public void StartRightRoll()
    {
        ResetStates();
        myAnimator.SetBool("rightRoll", true);


    }
    void RightRoll()
    {
        myAnimator.SetBool("rightRoll", true);
        if (!Input.GetButtonDown("Fire3"))
        {
            StopRightRoll();
        }

    }
    void StopRightRoll()
    {
        myAnimator.SetBool("rightRoll", false);
    }

    //GRAVITY AND MOVEMENT FUNCTIONS
    void ApplyGravity()
    {
        if (myYVelocity > terminalYVelocity)
        {
            myYVelocity += gravity * Time.deltaTime;
        }
        else if (myYVelocity != terminalYVelocity)
        {
            myYVelocity = terminalYVelocity;
        }
        else
        {
            myYVelocity = myDefaultYVelocity;
        }
    }

    void RotateCharacter()
    {
        Quaternion desiredRotation = Quaternion.LookRotation(new Vector3((transform.position.x - mainCameraTransform.position.x), 0, (transform.position.z - mainCameraTransform.position.z)), Vector3.up);
        //transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, 5f * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, 1f * Time.deltaTime);
    }

    void MoveCharacter()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float zAxis = Input.GetAxis("ZAxis");


        Vector3 moveDirection = new Vector3(horizontal, vertical, zAxis);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

}

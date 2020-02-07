using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GnomeMovement : MonoBehaviour
{
    //BASIC VARIABLES

    [SerializeField] private float speed = 5f; //Base movement speed.
    public Transform myTransform; //This object's transform component (used for optimization).
    [SerializeField] public static Rigidbody rb;
    public Collider playerCollider; //Player Collider.
    private CharacterController myController; //Reference to Character Controller component on GO.
    static public Rigidbody playerRigidbody;
    public Transform mainCameraTransform;
    public Camera mainCamera; //Main Camera.
    public Animator myAnimator; //Animator Controller.
    private AnimatorStateInfo myAnimatorStateInfo;// ???
    private float myAnimatorNormalizedTime = 0.0f;// ???

    public Vector3 zeroVelocity = new Vector3(0,0,0);
    public Vector3 negativeVelocity = Vector3.down;
   

    //PARTICLE SYSTEMS
    public ParticleSystem hitParticles;
    

    
    //STATE MACHINE
    private string currentState = "none";

    //MOVEMENT/ANIMATIOM VARIABLES
    private Vector3 moveDirection = Vector3.zero;//Vector to move towards?
    private float myYVelocity = 0.0f; //Current Y speed of the avatar.
    public float turnSpeed = 20f;

    //Collider .move variables
    public float jumpSpeed = 30.0f;
    
    //JUMP VARIABLES

    //Gravity
    private float gravity = -9.81f;

    //Velocity
    public float terminalYVelocity = -9f; //Meters per seconds.
    public float myDefaultYVelocity = -1.0f; //Default Y speed when the character is grounded.

    ///Jump
    public float jumpYVelocity = 3f; //Initial Jump speed.
    public float jumpCancelYVelocity = 6f; //Speed to  which the jump can be cancelled.

    ////INPUT VARIABLES
    //private float mouseXInput = 0.0f; //To know if the player is aiming left or right with the mouse.
    //private float mouseYInput = 0.0f; //To know if the player is aiming up or down with the mouse.
    private float verticalInput = 0.0f; //To know if the player is pressing forward (w) or back (s).
    private float horizontalInput = 0.0f; //To know if the player is pressing left or right (a or d).
    private float zAxisInput = 0.0f; // To know if the player is moving positively or negatively along the Z axis (r or f).
    //private float mouseSensitivity = 3.0f; //Mouse speed.

    public static bool isIdle;
    public static bool isFallingIdle;

    //Input Actions

    KeyboardControls inputAction;

    //Movement

    Vector3 movementInput;

    //Shift Flips

    Vector3 flips;



    public void Awake()
    {
        Cursor.visible = false;
        mainCamera = Camera.main;
        myAnimator = GetComponent<Animator>();
        myController = GetComponent<CharacterController>();
        playerRigidbody = GetComponent<Rigidbody>();

        inputAction = new KeyboardControls();
        inputAction.KeyBoardControls.Movement.performed += ctor => movementInput = ctor.ReadValue<Vector3>();
    }

    private void Start()
    {
        Points.points = 0f;
        isFallingIdle = true;

    }

    public void Update()
    {
        if (isFallingIdle == true)
        {
            isIdle = false;
        }
        if (isIdle == true)
        {
            StartIdle();
            isFallingIdle = false;
        }

        
        RunStates();
        RecordInput();


        if (speed >= 500f)
        {
            speed = 200f;
        }

        Debug.Log("CURRENT BOOST: " + Points.boost);
        
    }

    void FixedUpdate()
    {
        ApplyGravity();
        MoveCharacter();
        RotateCharacter();

    }
    void LateUpdate()
    {
        
        if (Points.boost <= 0f)
        {
            Points.boost = 0f;
        }
        else if (Points.boost >= 10000f)
        {
            Points.boost = 10000f;
        }
    }
    //START DUMMY AVATAR SCRIPT COPY
    void RunStates()
    {
        //Start new state using priority system
        //Idle
        if (currentState == "isIdle")
        { StartIdle(); }
        //Falling Idle
        else if (currentState == "isFallingIdle" /*&& currentState != "isIdle"*/)
        { StartFallingIdle(); }
        //Front Flip
        else if (currentState == "isFlipping" /*&& currentState != "isIdle"*/)
        { StartFlip(); }
        //Back Flip
        else if (currentState == "isBackFlipping" /*&& currentState != "isIdle"*/)
        { StartBackFlip(); }

        else if (currentState == "isRollingLeft" /*&& currentState != "isFallingIdle"*/)
        { StartLeftRoll(); }

        else if (currentState == "isRollingRight" /*&& currentState != "isFallingIdle"*/)
        { StartRightRoll(); }

        else if (currentState == "isHeadSpinning")
        {
            StartHeadSpin();
        }
        else if (currentState == "Jumping")
        {
            StartJump();
        }
        else if (currentState == "isDiving")
        {
            StartNoseDive();
        }
        else if (currentState == "isWalking")
        {
            StartWalk();
        }
        else if (currentState == "isCartWheeling")
        {
            StartCartWheel();
        }
        else if (currentState == "isCartWheelingRight")
        {
            StartCartWheelRight();
        }
        else if (currentState == "isMoonWalking")
        {
            StartMoonWalk();
        }
        else if (currentState == "isFloating")
        {
            StartFloatUp();
        }
        else if (currentState == "isSpinningForward")
        {
            StartSpinForward();
        }
        else if (currentState == "isSpinningRight")
        {
            StartSpinRight();
        }
        else if (currentState == "isSpinningBack")
        {
            StartSpinBack();
        }
        //Run ongoing states
        if (currentState == "isIdle") StartFallingIdle();
        else if (currentState == "isFallingIdle") StartFallingIdle();
        else if (currentState == "isFlipping") StartFlip();
        else if (currentState == "isBackFlipping") StartBackFlip();
        else if (currentState == "isRollingLeft") StartLeftRoll();
        else if (currentState == "isRollingRight") StartRightRoll();
        else if (currentState == "Jumping") StartJump();
        else if (currentState == "isHeadSpinning") StartHeadSpin();
        else if (currentState == "isDiving") StartNoseDive();
        else if (currentState == "isWalking") StartWalk();
        else if (currentState == "isCartWheeling") StartCartWheel();
        else if (currentState == "isCartWheelingRight") StartCartWheelRight();
        else if (currentState == "isMoonWalking") StartMoonWalk();
        else if (currentState == "isFloating") StartFloatUp();
        else if (currentState == "isSpinningForward") StartSpinForward();
        else if (currentState == "isSpinningRight") StartSpinRight();
        else if (currentState == "isSpinningBack") StartSpinBack();


        //Animator State Info
        myAnimatorStateInfo = myAnimator.GetCurrentAnimatorStateInfo(0);
        myAnimatorNormalizedTime = myAnimatorStateInfo.normalizedTime;
    }

    //END DUMMY AVATAR SCRIPT COPY

    //START RECORD INPUT FUNCTION SCRIPT COPY

    void RecordInput()
    {
        //Record movement axis input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //HANG INPUT

        //if (?)
        //{
        //    Hanging();
        //}



        //WALK FORWARD

        if (Input.GetKey(KeyCode.W) && (!Input.GetButton("Fire3")) && (!Input.GetButton("Fire2"))/*&& currentState!="isFallingIdle"*/  /*&& isIdle == true*/)
        {
            StartWalk();
        }
        //SPIN FORWARD
        if (Input.GetKey(KeyCode.W) && (!Input.GetButton("Fire3") && (Input.GetButton("Fire2"))))
        {
            StartSpinForward();
        }

        //WALK BACK (MOONWALK)

        if (Input.GetKey(KeyCode.S) && (!Input.GetButton("Fire3")  && (!Input.GetButton("Fire2")) /*&& isIdle == true*/))
        {
            StartMoonWalk();
        }

        //CARTWHEEL(LEFT) INPUT

        if (Input.GetKey(KeyCode.A) && (!Input.GetButton("Fire3")) && (!Input.GetButton("Fire2")) /*&& isIdle == true*/)
        {
            StartCartWheel();

        }
        //CARTWHEEL(RIGHT) INPUT

        if (Input.GetKey(KeyCode.D) && (!Input.GetButton("Fire3")) && (!Input.GetButton("Fire2")) /*&& isIdle == true*/)
        {
            StartCartWheelRight();

        }

        //SPIN RIGHT INPUT

        if (Input.GetKey(KeyCode.D) && (!Input.GetButton("Fire3") && (Input.GetButton("Fire2"))))
        {
            StartSpinRight();
        }

        //JUMP INPUT

        if (Input.GetButton("Jump") /*&& isIdle == true*/)
        {
            StartJump();
        }


        //FLOAT UP INPUT
        if (Input.GetKey(KeyCode.R) && Points.boost > 100)
        {
            StartFloatUp();
        }

            //NOSE DIVE INPUT


            if (Input.GetKey(KeyCode.F) && Points.boost > 100)
            {
                StartNoseDive();

                speed *= 1.2f;
        }
        //else { StartFallingIdle(); }

        
        
      
        //HEAD SPIN INPUT

        if (Input.GetButtonDown("Fire2") && Input.GetKey(KeyCode.A) && Points.boost > 100 /*&& isIdle == true*/)
        {
            StartHeadSpin();
        }


        //FLIP INPUT

        if (Input.GetButtonDown("Fire3") && Input.GetKey(KeyCode.W) && Points.boost > 100)
        {
            
            StartFlip();


        }
        //BACKFLIP INPUT

        if (Input.GetButtonDown("Fire3") && Input.GetKey(KeyCode.S) && Points.boost > 100)
        {
            StartBackFlip();
        }
        //BACK SPIN INPUT

        if (Input.GetButtonDown("Fire2") && Input.GetKey(KeyCode.Space) && Points.boost > 100)
        {
            StartSpinBack();
        }
        speed -= 0.01f;
        if (speed <= 50)
        {
            speed = 50;
        }



        //LEFT ROLL INPUT
        if (Input.GetButtonDown("Fire3") && Input.GetKey(KeyCode.A) && Points.boost > 100)
        {
            StartLeftRoll();

        }
        //RIGHT ROLL INPUT
        if (Input.GetButtonDown("Fire3") && Input.GetKey(KeyCode.D) && Points.boost > 100)
        {
            StartRightRoll();

        }
        else if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && isIdle==false)
        {
            StartFallingIdle();
        }
        else if ((!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && isIdle == true))
        {
            StartIdle();
        }

        myAnimatorStateInfo = myAnimator.GetCurrentAnimatorStateInfo(0);
        myAnimatorNormalizedTime = myAnimatorStateInfo.normalizedTime;

        if (Points.boost <= 0)
        {
            StartFallingIdle();
        }

        ////Record camera axis input
        ////Mouse
        //if (cameraXAxisInverted) { mouseXInput = -Input.GetAxis("Mouse X"); } else { mouseXInput = Input.GetAxis("Mouse X"); }
        //if (cameraYAxisInverted) { mouseYInput = -Input.GetAxis("Mouse Y"); } else { mouseYInput = Input.GetAxis("Mouse Y"); }

        ////Action input
        //runInput = Input.GetButton("Fire3");
        //attackInput = Input.GetButtonDown("Fire1");

        ////Double tap input (for running)
        //if (dblTapDelay == defaultDblTapDelay && !dblTapInput1)
        //{ dblTapInput1 = Input.GetButtonDown("Vertical"); }
        //else if ((dblTapInput1 && dblTapDelay > 0) || dblTapInput2)
        //{
        //    if (dblTapDelay > 0) { dblTapDelay -= 1 * Time.deltaTime; }
        //    if (!dblTapInput2) { dblTapInput2 = Input.GetButtonDown("Vertical"); }
        //    else { dblTapInput2 = Input.GetButton("Vertical"); }
        //}
        //else
        //{
        //    dblTapInput1 = false;
        //    dblTapInput2 = false;
        //    dblTapDelay = defaultDblTapDelay;
        //}
    }
    //RESET STATES

    void ResetStates()
    {
        currentState = "none";
        StopBackFlip();
        StopFlip();
        StopLeftRoll();
        StopRightRoll();
        StopJump();
        StopFallingIdle();
        StopIdle();
        
        StopNoseDive();
        StopWalk();
        StopCartWheel();
        StopCartWheelRight();
        StopMoonWalk();
        StopFloatUp();
        StopSpinForward();
        StopHeadSpin();
        StopSpinRight();
        StopSpinBack();
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject)
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Hit other object:" + collision.gameObject.name);
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Cube")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log(collision);
            currentState = "isIdle";
            isIdle = true;

            StartIdle();
        }
        if (collision.gameObject.tag =="Junk")
        {
            Points.boost += 100f;
            Debug.Log("Hit Junk.");
            PlayerHealth.currentHealth -= 1f;
            Destroy(collision.gameObject);
            isIdle = true;
        }
        //else
        //{
        //    StartFallingIdle();
        //}


    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            Debug.Log(collision);
            currentState = "isFallingIdle";
            //isIdle = false;

            StartFallingIdle();
        }
        
    }
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        // no rigidbody
        if (body == null || body.isKinematic)
        {
            Debug.Log("Player collided with non-Rigidbody object or Kinematic Rigidbody:" + hit.collider.attachedRigidbody);

        }
        if (body != null)
        {
            Debug.Log("Player collided with Rigidbody: " + body.gameObject.name);
            
        }
       
    }

   

    
    //STATE FUNCTIONS

    //WALK

        void StartWalk()
    {
        ResetStates();
        currentState = "isWalking";
        myAnimator.SetBool("walkForward", true);
    }
        void Walk()
    {
        if (!Input.GetKey(KeyCode.W))
        {
            StopWalk();
        }
    }
        void StopWalk()
    {
        myAnimator.SetBool("walkForward", false);
        isFallingIdle = true;
    }
    
    //FRONT SPIN

        void StartSpinForward()
    {
        ResetStates();
        currentState = "isSpinningForward";
        myAnimator.SetBool("spinForward", true);
    }
        void SpinForward()
    {
        if (!Input.GetButton("Fire2"))
        {
            StopSpinForward();
        }
    }
        void StopSpinForward()
    {
        myAnimator.SetBool("spinForward", false);
    }

    //WALK BACKWARDS (MOON WALK)

void StartMoonWalk()
    {
        ResetStates();
        myAnimator.SetBool("walkBack", true);
        currentState = "isMoonWalking";
    }
    void MoonWalk()
    {
        if (!Input.GetKey(KeyCode.S))
        {
            StopMoonWalk();
        }
    }
    void StopMoonWalk()
    {
        myAnimator.SetBool("walkBack", false);
    }

    //SPIN BACKWARDS

    void StartSpinBack()
    {
        ResetStates();
        myAnimator.SetBool("StartSpinBack", true);
        currentState = "isSpinningBack";
    }
    void SpinBack()
    {
        if (!Input.GetKey(KeyCode.S))
        {
            StopSpinBack();
        }
    }
    void StopSpinBack()
    {
        myAnimator.SetBool("spinBack", false);
    }
    //FALLING IDLE

    void StartFallingIdle()
    {
        ResetStates();

        currentState = "isFallingIdle";
        myAnimatorNormalizedTime = 0;
        myAnimator.SetBool("isFallingIdle", true);
        isFallingIdle = true;
       
    }
    void FallingIdle()
    {
        if (currentState!="isFallingIdle")
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

        currentState = "isIdle";
        myAnimatorNormalizedTime = 0;
        myAnimator.SetBool("standingIdle", true);
        isIdle = true;
        
    }
    void Idle()
    {
      
        if (currentState!="isIdle")
            {
                StopIdle();
            }
            
        
    }
    void StopIdle()
    {
        myAnimator.SetBool("standingIdle", false);
        isFallingIdle = true;


    }
    //JUMPING
    void StartJump()
    {
        ResetStates();
        currentState = "Jumping";
        myAnimator.SetBool("Jumping", true);
    }

    void Jump()
    {


        if (!Input.GetButton("Jump"))
        {
            StopJump();
        }//Cancel the jump momentum if the jump button is released.
        //{
        //    //myYVelocity = jumpCancelYVelocity;
        //    StopJump();
        //}
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
        currentState = "isFlipping";
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
    //BACKFLIPPING
    public void StartBackFlip()
    {
        ResetStates();
        currentState = "isBackFlipping";
        myAnimator.SetBool("backFlip", true);
        

    }
    void BackFlip()
    {
        
        if (!Input.GetButton("Fire3"))
        {
            StopBackFlip();
        }

    }
    void StopBackFlip()
    {
        myAnimator.SetBool("backFlip", false);
        
    }

    //CARTWHEEL (LEFT)

    void StartCartWheel()
    {
        ResetStates();
        myAnimator.SetBool("cartWheel", true);

    }
    void CartWheel()
    {
        if (!Input.GetKey(KeyCode.A))
        {
            StopCartWheel();
        }
    }

    void StopCartWheel()
    {
        myAnimator.SetBool("cartWheel", false);
    }
    //CARTWHEEL (LEFT)

    void StartCartWheelRight()
    {
        ResetStates();
        myAnimator.SetBool("cartWheelRight", true);

    }
    void CartWheelRight()
    {
        if (!Input.GetKey(KeyCode.D))
        {
            StopCartWheelRight();
        }
    }

    void StopCartWheelRight()
    {
        myAnimator.SetBool("cartWheelRight", false);
    }
    //LEFT ROLL
    public void StartLeftRoll()
    {
        ResetStates();
        currentState = "isRollingLeft";
        myAnimator.SetBool("leftRoll", true);

    }
    void LeftRoll()
    {
        
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
        currentState = "isRollingRight";
        myAnimator.SetBool("rightRoll", true);
        

    }
    void RightRoll()
    {
        
        if (!Input.GetButtonDown("Fire3"))
        {
            StopRightRoll();
        }

    }
    void StopRightRoll()
    {
        myAnimator.SetBool("rightRoll", false);
    }

    //RIGHT HEAD SPINNING
    void StartSpinRight()
    {
        ResetStates();
        currentState = "isSpinningRight";
        myAnimator.SetBool("spinRight", true);
    }
    void SpinRight()
    {
        if (!Input.GetButton("Fire2"))
        {
            StopSpinRight();
        }
    }
    void StopSpinRight()
    {
        myAnimator.SetBool("spinRight", false);
    }

    //LEFT HEAD SPINNING

    void StartHeadSpin()
    {
        ResetStates();
        currentState = "isHeadSpinning";
        myAnimator.SetBool("headSpin", true);
    }
    void HeadSpinning()
    {
        //if (!Input.GetButtonDown("Fire3"))
        //{
        //    StopHeadSpin();
        //}
    }
    void StopHeadSpin()
    {
        myAnimator.SetBool("headSpin", false);  
    }
    //FLOATING

        void StartFloatUp()
    {
        ResetStates();
        myAnimator.SetBool("floatUp", true);
        currentState = "isFloating";
    }
    void FloatUp()
    {
        if (!Input.GetKey(KeyCode.R))
        {
            StopFloatUp();
        }
    }
    void StopFloatUp()
    {
        myAnimator.SetBool("floatUp", false);
    }


    //DIVING

    void StartNoseDive()
    {
        ResetStates();
        myAnimator.SetBool("noseDive", true);
        currentState = "isDiving";
    }
    void NoseDive()
    {
        if (!Input.GetKeyDown(KeyCode.F))
        {
            StopNoseDive();
        }
    }
    void StopNoseDive()
    {
        myAnimator.SetBool("noseDive", false);
    }


    ////HANGING
    //void Hanging()
    //{
    //    ResetStates();
    //    currentState = "Hanging Idle";
    //    myAnimator.SetBool("isHanging", true);
    //    Hang();
    //}
    //void Hang()
    //{
    //    currentState = "Hanging Idle";
    //    myAnimator.SetBool("isHanging", true);
    //    if (!myController.isGrounded)
    //    {
    //        StopHang();
    //    }
    //}
    //void StopHang()
    //{
    //    myAnimator.SetBool("isHanging", false);
    //    currentState = "none";
    //}

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
    ////Character Rotation
    void RotateCharacter()
    {
        Quaternion desiredRotation = Quaternion.LookRotation(new Vector3((transform.position.x - mainCameraTransform.position.x), 0, (transform.position.z - mainCameraTransform.position.z)), Vector3.up);
        //transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, 5f * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, 1f * Time.deltaTime);
    }
    //Character Movement
    void MoveCharacter()
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

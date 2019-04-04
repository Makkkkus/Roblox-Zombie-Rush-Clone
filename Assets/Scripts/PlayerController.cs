using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float sensitivity = 2.5f;
    [SerializeField] private float walkingSpeed = 2.0f;
    [SerializeField] private float sprintingSpeed = 2.5f;
    private float gravity = 15.0f;
    private float jumpForce = 7.0f;
    private float player_MoveSpeed;
    
    //Unity Components
    private CharacterController controller;
    private GameObject playerCamera;
    private Vector3 moveDir = Vector3.zero;

    private void Awake () {
        controller = GetComponent<CharacterController>();
        playerCamera = GameObject.FindWithTag("MainCamera");
	}

    private void Start()
    {
        //Set player speed to walking
        player_MoveSpeed = walkingSpeed;

        //Cursor lock
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        //Get input
        float moveH = Input.GetAxis("Horizontal") * player_MoveSpeed;
        float moveV = Input.GetAxis("Vertical") * player_MoveSpeed;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //Check if sprinting
        if (Input.GetButton("Sprint")) player_MoveSpeed = sprintingSpeed;
        else player_MoveSpeed = walkingSpeed;

        //Falling and jumping
        if (controller.isGrounded)
        {
            moveDir.y = -gravity * Time.deltaTime;
            moveDir = new Vector3(moveH, 0.0f, moveV);
            moveDir = transform.TransformDirection(moveDir);
            moveDir = moveDir * player_MoveSpeed;

            if (Input.GetButton("Jump")) moveDir.y = jumpForce;
        }
        else
        {
            moveDir.y = moveDir.y - (gravity * Time.deltaTime);
        }

        //Moving
        transform.Rotate(0, mouseX * sensitivity, 0, Space.World);
        playerCamera.transform.Rotate(-mouseY * sensitivity, 0, 0);
        controller.Move(moveDir * Time.deltaTime);
    }
}
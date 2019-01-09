using UnityEngine;

public class CharacterMove : MonoBehaviour {

    CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    Camera playerCamera;
    [SerializeField]
    private float mouse_sensitivity = 2.5f;
    private float walkingSpeed = 2.0f;
    private float sprintingSpeed = 2.25f;
    private float gravity = 15.0f;
    private float jumpForce = 7.0f;

	void Start () {
        controller = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();
	}

	void FixedUpdate () {
        float Player_MoveSpeed =  walkingSpeed;

        float moveH = Input.GetAxis("Horizontal") * Player_MoveSpeed;
        float moveV = Input.GetAxis("Vertical") * Player_MoveSpeed;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (Input.GetButton("Sprint")) Player_MoveSpeed = sprintingSpeed;
        else Player_MoveSpeed = walkingSpeed;

        if (controller.isGrounded)
        {
            moveDir.y = -gravity * Time.deltaTime;
            moveDir = new Vector3(moveH, 0.0f, moveV);
            moveDir = transform.TransformDirection(moveDir);
            moveDir = moveDir * Player_MoveSpeed;

            if (Input.GetButton("Jump")) moveDir.y = jumpForce;
        }
        else
        {
            moveDir.y = moveDir.y - (gravity * Time.deltaTime);
        }

        transform.Rotate(0, mouseX * mouse_sensitivity, 0, Space.World);
        playerCamera.transform.Rotate(-mouseY * mouse_sensitivity, 0, 0);
        controller.Move(moveDir * Time.deltaTime);

	}
}
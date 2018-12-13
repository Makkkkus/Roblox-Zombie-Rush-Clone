using UnityEngine;

public class CharacterMove : MonoBehaviour {

    CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    Camera playerCamera;
    [SerializeField]
    private float sensitivity = 2.5f;
    private float walkingSpeed = 2.0f;
    private float sprintingSpeed = 2.25f;
    private float gravity = 15.0f;
    private float jumpForce = 7.0f;

	void Start () {
        controller = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();
	}

	void FixedUpdate () {
        float moveSpeed;

        if (Input.GetButton("Sprint"))
        {
            moveSpeed = sprintingSpeed;
        }
        else
        {
            moveSpeed = walkingSpeed;
        }

        float moveH = Input.GetAxis("Horizontal") * moveSpeed;
        float moveV = Input.GetAxis("Vertical") * moveSpeed;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (controller.isGrounded)
        {
            moveDir.y = -gravity * Time.deltaTime;
            moveDir = new Vector3(moveH, 0.0f, moveV);
            moveDir = transform.TransformDirection(moveDir);
            moveDir = moveDir * moveSpeed;

            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpForce;
            }
        }
        else
        {
            moveDir.y = moveDir.y - (gravity * Time.deltaTime);
        }

        transform.Rotate(0, mouseX, 0, Space.World);
        playerCamera.transform.Rotate(-mouseY, 0, 0);
        controller.Move(moveDir * Time.deltaTime);

	}
}
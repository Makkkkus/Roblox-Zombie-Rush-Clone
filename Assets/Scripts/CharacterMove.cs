using UnityEngine;

public class CharacterMove : MonoBehaviour {

    CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    Camera playerCamera;
    float moveSpeed = 2.5f;
    float gravity = 16.0f;
    float jumpForce = 10.0f;

	void Start () {
        controller = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();
	}

	void FixedUpdate () {

        float moveH = Input.GetAxis("Horizontal") * moveSpeed;
        float moveV = Input.GetAxis("Vertical") * moveSpeed;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (Input.GetButton("Sprint"))
        {
            moveSpeed = 3.5f;
        }
        else
        {
            moveSpeed = 2.5f;
        }

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
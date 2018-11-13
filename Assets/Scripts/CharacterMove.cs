using UnityEngine;

public class CharacterMove : MonoBehaviour {

    CharacterController controller;
    float speed = 5.0f;
    float gravity = 14.0f;
    float jumpForce = 10.0f;
    float vertivalVelocity;

	void Start () {
        controller = GetComponent<CharacterController>();
	}

	void FixedUpdate () {

        float moveForward = Input.GetAxis("Forward") * speed;
        float moveBack = Input.GetAxis("Backward") * speed;
        float moveLeft = Input.GetAxis("Left") * speed;
        float moveRight = Input.GetAxis("Right") * speed;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (controller.isGrounded)
        {
            vertivalVelocity = -gravity * Time.deltaTime;

            if (Input.GetButtonDown("Jump"))
            {
                vertivalVelocity = jumpForce;
            }
        } else
        {
            vertivalVelocity -= gravity * Time.deltaTime;
        }

        transform.Rotate(0, mouseX, 0, Space.World);
        transform.Rotate(-mouseY, 0, 0);
        controller.Move(new Vector3((moveRight + moveLeft) * Time.deltaTime, vertivalVelocity * Time.deltaTime, (moveForward + moveBack) * Time.deltaTime));

	}
}
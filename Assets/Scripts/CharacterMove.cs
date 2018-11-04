using UnityEngine;

public class CharacterMove : MonoBehaviour {

    CharacterController controller;
    float speed = 5.0f;
    float gravity = 3.5f;
    float jumpForce = 2.5f;
    float vertivalVelocity;

	void Start () {
        controller = GetComponent<CharacterController>();
	}

	void FixedUpdate () {

        float moveForward = Input.GetAxis("Forward") * speed * Time.deltaTime;
        float moveBack = Input.GetAxis("Backward") * speed * Time.deltaTime;
        float moveLeft = Input.GetAxis("Left") * speed * Time.deltaTime;
        float moveRight = Input.GetAxis("Right") * speed * Time.deltaTime;

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

        controller.Move(new Vector3(moveRight + moveLeft, vertivalVelocity, moveForward + moveBack));

	}
}
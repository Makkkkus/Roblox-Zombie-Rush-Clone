using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Settings
    private const float walkingSpeed = 2.0f;
    private const float sprintingSpeed = 2.5f;
    private const float gravity = 15.0f;
    private const float jumpForce = 6.0f;
    private float player_MoveSpeed;

    // Unity Components
    private CharacterController controller;
    private Vector3 moveDir = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();

        // Set player speed to walking
        player_MoveSpeed = walkingSpeed;

        // Cursor lock
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        // Get input
        float moveH = Input.GetAxis("Horizontal") * player_MoveSpeed;
        float moveV = Input.GetAxis("Vertical") * player_MoveSpeed;
        float mouseX = Input.GetAxis("Mouse X");

        // Check if sprinting
        if (Input.GetButton("Sprint")) player_MoveSpeed = sprintingSpeed;
        else player_MoveSpeed = walkingSpeed;

        // Falling and jumping
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
            moveDir = new Vector3(moveH * player_MoveSpeed, moveDir.y, moveV * player_MoveSpeed);
            moveDir = transform.TransformDirection(moveDir);
            moveDir.y = moveDir.y - (gravity * Time.deltaTime);
        }

        // Moving
        controller.Move(moveDir * Time.deltaTime);
    }
}
using System;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(CharacterController))]

public class pc_Movement : MonoBehaviour
{
    public float moveSpeed;

    private InputAction moveAction;
    private Vector3 movement;
    private Vector2 movementV2;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();

        moveAction = InputSystem.actions.FindAction("Move");
    }

    private void Update()
    {
        movementV2 = moveAction.ReadValue<Vector2>();
        movement = (new Vector3(movementV2.x, 0, movementV2.y)) * moveSpeed * Time.deltaTime;
        _characterController.Move(movement);
    }
}

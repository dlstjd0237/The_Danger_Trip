using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerInput.FloorActions _onFloor;
    private PlayerMotor _playerMotor;
    private PlayerLook _playerLook;
    private void Awake()
    {
        _playerInput = new PlayerInput();
        _onFloor = _playerInput.Floor;
        _playerMotor = GetComponent<PlayerMotor>();
        _playerLook = GetComponent<PlayerLook>();
        _onFloor.Jump.performed += ctx => _playerMotor.Jump();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        _playerMotor.PlayerMove(_onFloor.Move.ReadValue<Vector2>());
    }
    private void LateUpdate()
    {
        _playerLook.ProcessLook(_onFloor.Look.ReadValue<Vector2>());
    }
    private void OnDisable()
    {
        _playerInput.Disable();
    }
    private void OnEnable()
    {
        _playerInput.Enable();
    }
}

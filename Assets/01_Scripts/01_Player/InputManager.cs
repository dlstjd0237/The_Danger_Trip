using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    public PlayerInput.FloorActions OnFloor;
    private PlayerMotor _playerMotor;
    private PlayerLook _playerLook;
    private void Awake()
    {
        _playerInput = new PlayerInput();
        OnFloor = _playerInput.Floor;
        _playerMotor = GetComponent<PlayerMotor>();
        _playerLook = GetComponent<PlayerLook>();
        OnFloor.Jump.performed += ctx => _playerMotor.Jump();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        _playerMotor.PlayerMove(OnFloor.Move.ReadValue<Vector2>());
    }
    private void LateUpdate()
    {
        _playerLook.ProcessLook(OnFloor.Look.ReadValue<Vector2>());
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

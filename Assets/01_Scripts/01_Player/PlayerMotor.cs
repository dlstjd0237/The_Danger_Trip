using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController _character;
    private Vector3 _playerVelocity;
    private bool _isGround;
    private float _gravity = -9.8f;
    [SerializeField] private float _speed = 2;
    [SerializeField] private float _jumpPower = 1;
    private void Awake()
    {
        _character = GetComponent<CharacterController>();
    }
    private void Update()
    {
        _isGround = _character.isGrounded;
    }
    public void PlayerMove(Vector2 input)
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = input.x;
        moveDir.z = input.y;
        _character.Move(transform.TransformDirection(moveDir) * _speed * Time.deltaTime);
        _playerVelocity.y += _gravity * Time.deltaTime;
        if (_isGround && _playerVelocity.y < 0)
            _playerVelocity.y = -2f;
        _character.Move(_playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (_isGround)
        {
            _playerVelocity.y = Mathf.Sqrt(_jumpPower * -3.0f * _gravity);
        }
    }
}

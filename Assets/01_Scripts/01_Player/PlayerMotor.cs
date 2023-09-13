using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController _character;
    private Vector3 _playerVelocity;
    private bool _isGround;
    private float _gravity = -9.8f;
    private PlayerAnimationControll _ani;
    [SerializeField] private float _speed = 2;
    [SerializeField] private float _jumpPower = 1;
    private void Awake()
    {
        _character = GetComponent<CharacterController>();
        _ani = GetComponent<PlayerAnimationControll>();
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
        if (moveDir != Vector3.zero)
        {
            _ani.WalkingAni(moveDir.normalized  );
        }
        else
        {
            _ani.ReSetAni();
        }
        _character.Move(transform.TransformDirection(moveDir) * _speed * Time.deltaTime);
        _playerVelocity.y += _gravity * Time.deltaTime;
        if (_isGround && _playerVelocity.y < 0)
            _playerVelocity.y = -2f;
        _character.Move(_playerVelocity * Time.deltaTime);
    }

    public void SprintOn()
    {
        _speed *= 1.5f;
        _ani.RunOn();
    }
    public void SprintOff()
    {
        _speed /= 1.5f;
        _ani.RunOff();
    }

    public void Jump()
    {
        if (_isGround)
        {
            _playerVelocity.y = Mathf.Sqrt(_jumpPower * -3.0f * _gravity);
        }
    }
}

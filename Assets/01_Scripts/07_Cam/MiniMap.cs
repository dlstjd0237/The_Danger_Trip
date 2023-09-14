using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    private Transform _player;
    private void Awake()
    {
        _player = GameObject.Find("Player").transform;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(_player.position.x, transform.position.y, _player.position.z);
        transform.localRotation = Quaternion.Euler(90, 0, _player.rotation.y);
    }
}

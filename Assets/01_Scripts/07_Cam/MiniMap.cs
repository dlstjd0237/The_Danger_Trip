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
        transform.eulerAngles = new Vector3(90,90, -_player.eulerAngles.y+90);
    }
    
}

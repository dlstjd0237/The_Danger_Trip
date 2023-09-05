using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Chapter01_Controll : MonoBehaviour
{
    private Transform _player;
    [SerializeField]private Vector3 bedDir;
    private void Awake()
    {
        _player = GameObject.Find("Player").transform;
    }

    private void Start()
    {
        Sequence q1 = DOTween.Sequence();
        q1.Append(_player.DOMove(bedDir, 3));
        q1.Join(_player.DORotate(new Vector3(0,90,0), 3));
        q1.AppendCallback(() => { _player.GetComponent<CharacterController>().enabled = true; _player.GetComponent<InputManager>().enabled = true; });
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SlidingDoor : Interactable
{
    private Vector3 StartPos;
    [SerializeField] private GameObject _slidingDoor;
    [Header("문열리고 마지막으로 도착하는 위치")]
    [SerializeField] private Vector3 EndPos;
    [Header("두트윈 두레이숀   ")]
    [SerializeField] private float duration = 2;
    private bool isOpne;
    private void Start()
    {
        StartPos = _slidingDoor.transform.localPosition;
    }
    protected override void Interact()
    {
        if (isOpne)
        {
            isOpne = false;
            _slidingDoor.transform.DOLocalMove(StartPos, duration);
        }
        else if (!isOpne)
        {
            isOpne = true;
            _slidingDoor.transform.DOLocalMove(EndPos, duration);
        }
    }
}

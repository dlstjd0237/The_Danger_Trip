using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SlidingDoor : Interactable
{
    private Vector3 StartPos;
    [Header("�������� ���������� �����ϴ� ��ġ")]
    [SerializeField] private Vector3 EndPos;
    [Header("��Ʈ�� �η��̼�   ")]
    [SerializeField] private float duration=2;
    private bool isOpne;
    private void Start()
    {
        StartPos =transform.localPosition;
    }
    protected override void Interact()
    {
        if (isOpne)
        {
            isOpne = false;
            transform.DOLocalMove(StartPos, duration);
        }
        else if (!isOpne)
        {
            isOpne = true;
            transform.DOLocalMove(EndPos, duration);
        }
    }
}

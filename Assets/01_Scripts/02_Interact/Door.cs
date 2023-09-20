using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Door : Interactable
{
    private bool _isOpen = false;
    [SerializeField]
    private Vector3 Close, Open;
    [SerializeField] private GameObject _door;
    protected override void Interact()
    {
        if (_isOpen==false)
        {
            _door.transform.DOLocalRotate(Open, 2);
            promptMessage = "[닫기]";
            _isOpen = true;
        }
        else if (_isOpen==true)
        {
            _door.transform.DOLocalRotate(Close, 2);
            promptMessage = "[열기]";
            _isOpen = false;
            Debug.Log("와안되노");

        }
    }
}

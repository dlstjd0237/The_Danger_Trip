using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postit : Interactable
{
   [SerializeField]  Chapter01_UIToolkit UIToolkitCs;
    

    protected override void Interact()
    {
        if(!UIToolkitCs.OnElement)
        UIToolkitCs.OnPostIt("���� �ؾ�����\n1. ������ ì���\n2.���ܼ� ���ϱ�\n3.�����ϰ� ������ ���� �����ϱ�");
        else
        {
            UIToolkitCs.OffPostIt();
        }
    }
}

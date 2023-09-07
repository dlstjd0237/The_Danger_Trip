using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postit : Interactable
{
   [SerializeField]  Chapter01_UIToolkit UIToolkitCs;
    

    protected override void Interact()
    {
        if(!UIToolkitCs.OnElement)
        UIToolkitCs.OnPostIt("내일 해야할일\n1. 통조림 챙기기\n2.문단속 잘하기\n3.안전하게 목적지 까지 도착하기");
        else
        {
            UIToolkitCs.OffPostIt();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannedFood : Interactable
{
    protected override void Interact()
    {
        Destroy(gameObject);
    }
}

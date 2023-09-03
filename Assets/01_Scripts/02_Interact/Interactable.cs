using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    public void BassInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {

    }
}

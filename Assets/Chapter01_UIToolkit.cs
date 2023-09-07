using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;
public class Chapter01_UIToolkit : MonoBehaviour
{
    private UIDocument _dot;
    private VisualElement _background;
    private Label _dialogue;
    public bool OnElement;
    PlayerInput _playerInput;
    PlayerInput.InteractActions _Interact;
    private void Awake()
    {
        _playerInput = new PlayerInput();
        _Interact = _playerInput.Interact;
        _Interact.InteractOff.performed += ctx => OffPostIt();

        _dot = GetComponent<UIDocument>();
        _background = _dot.rootVisualElement.Q<VisualElement>("Background");
        _dialogue = _dot.rootVisualElement.Q<Label>("Dialogue");
    }

    public void OnPostIt(string contents)
    {
        _background.AddToClassList("on");
        _dialogue.text = contents;
        _dialogue.RemoveFromClassList("on");
        OnElement = true;
    }

    public void OffPostIt()
    {
        _background.RemoveFromClassList("on");
        _dialogue.AddToClassList("on");
        _dialogue.text = string.Empty;
        OnElement = false;
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }
    private void OnDisable()
    {
        _playerInput.Disable();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class Chapter01_UIToolkit : MonoBehaviour
{
    private UIDocument _dot;
    private VisualElement _postIt;
    private Label _postItLabel;
    private void Awake()
    {
        _dot = GetComponent<UIDocument>();
        _postIt = _dot.rootVisualElement.Q<VisualElement>("PostIt");
        _postItLabel = _dot.rootVisualElement.Q<Label>("PostItLabel");
    }

    public void OnPostIt(string contents)
    {
        _postIt.AddToClassList("on");
        _postItLabel.text = contents;
    }

    public void OffPostIt()
    {
        _postIt.RemoveFromClassList("on");
        _postItLabel.text = string.Empty;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : Singleton<UIManager>
{
    private TextMeshProUGUI _debugText;
    private GameObject _progress_bar;

    private void Awake()
    {
        _debugText = transform.Find("DebugLog").GetComponent<TextMeshProUGUI>();
        _progress_bar = transform.Find("Progress_bar").gameObject;
        _progress_bar.SetActive(false);
    }

    /// <summary>
    /// 디버그 텍스트 쪽에 넣을 텍스트를 넣으면 2초후 리셋됨
    /// </summary>
    /// <param name="text"></param>
    public void SetDebugText(string text)
    {
        _debugText.SetText(text);
        Invoke("ReSetDebugText", 2);
    }

    private void ReSetDebugText()
    {
        _debugText.SetText(string.Empty);
    }
}

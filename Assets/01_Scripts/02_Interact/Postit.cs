using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postit : Interactable
{
    [SerializeField] Chapter01_UIToolkit UIToolkitCs;
    private int _count = 0;
    [SerializeField] private GameObject sign;
    [SerializeField] private GameObject minimapSign;

    private OutlineShader outlineShader;

    private void Awake()
    {
        outlineShader = GetComponent<OutlineShader>();
    }
    protected override void Interact()
    {
        promptMessage = string.Empty;
        if (!UIToolkitCs.OnElement && _count == 0)
        {
            QuestManager.Instance.SetProgress();
            UIToolkitCs.OnPostIt("해야할일\n1. 통조림 챙기기\n2.문단속 잘하기\n3.안전하게 목적지 까지 도착하기");
            _count++;
            sign.SetActive(false);
            minimapSign.SetActive(false);
            Invoke("Cool", 3);
            outlineShader.Con = true;
            outlineShader.ShaderOff();
            outlineShader.enabled = false;
        }

    }

    private void Cool()
    {
        QuestManager.Instance.QuestOn(1002);
    }
}

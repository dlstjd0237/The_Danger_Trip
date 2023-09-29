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
            UIToolkitCs.OnPostIt("������ �𸣰�����\nWASD�� �����ϼ��ְ�\nE�� ��ȣ�ۿ� �Ҽ� ������ ����.   ");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postit : Interactable
{
    [SerializeField] Chapter01_UIToolkit UIToolkitCs;
    private int _count = 0;
    [SerializeField] private GameObject sign;
    [SerializeField] private GameObject minimapSign;



    protected override void Interact()
    {
        promptMessage = string.Empty;
        if (!UIToolkitCs.OnElement && _count == 0)
        {
            QuestManager.Instance.SetProgress();
            UIToolkitCs.OnPostIt("���� �ؾ�����\n1. ������ ì���\n2.���ܼ� ���ϱ�\n3.�����ϰ� ������ ���� �����ϱ�");
            _count++;
            sign.SetActive(false);
            minimapSign.SetActive(false);
            Invoke("Cool", 3);
        }

    }

    private void Cool()
    {
        QuestManager.Instance.QuestOn(1002);
    }
}

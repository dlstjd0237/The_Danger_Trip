using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : Singleton<QuestManager>
{
    public QuestSOList QuestSo;
    public Dictionary<int, QuestSO> QuestDic = new Dictionary<int, QuestSO>();
    private void Awake()
    {
        for (int i = 0; i < QuestSo.questSo.Count; i++)
        {
            QuestDic.Add(QuestSo.questSo[i].KeyValue, QuestSo.questSo[i]);
        }
        Debug.Log(QuestDic[1001].MinQuestProgress);
    }

    public QuestSO GetQuest(int QuestKey)
    {
        return QuestDic[QuestKey];
    }

    public void TriggerQuesManager()
    {

    }
}

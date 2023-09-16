using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class QuestManager : Singleton<QuestManager>
{
    public QuestSOList QuestSo;
    public Dictionary<int, QuestSO> QuestDic = new Dictionary<int, QuestSO>();

    private UIDocument _dot;
    private VisualElement _root;
    private Button _questButton;
    private Label _headLabel;
    private Label _bodyLavel;
    private int _currentProgress = 0;
    private int _maxProgress = 0;
    private int _currentQuestKey;
    private void Awake()
    {
        _dot = GetComponent<UIDocument>();
        _root = _dot.rootVisualElement;
        _headLabel = _root.Q<Label>("HeadLabel");
        _bodyLavel = _root.Q<Label>("BodyLabel");
        _questButton = _root.Q<Button>("QuestButton");

        for (int i = 0; i < QuestSo.questSo.Count; i++)
        {
            QuestDic.Add(QuestSo.questSo[i].KeyValue, QuestSo.questSo[i]);
        }
        Invoke("qwer", 3);
        Debug.Log(QuestDic[1001].MinQuestProgress);
    }
    private void qwer()
    {
        QuestOn(1001);
    }
    public QuestSO GetQuest(int QuestKey)
    {
        return QuestDic[QuestKey];
    }

    public void QuestOn(int QuestKeyValue)
    {
        QuestUIOn();
        _currentQuestKey = QuestKeyValue;
        _currentProgress = QuestDic[_currentQuestKey].MinQuestProgress;
        _maxProgress = QuestDic[_currentQuestKey].MaxQuestProgress;
        _headLabel.text = QuestDic[_currentQuestKey].TitleName;
        _bodyLavel.text = QuestDic[_currentQuestKey].QuestContents+$" {_currentProgress}/{_maxProgress}";
        
    }

    public void SetProgress()
    {
        _currentProgress++;
        _bodyLavel.text = QuestDic[_currentQuestKey].QuestContents + $" {_currentProgress}/{_maxProgress}";
        if (_currentProgress >= _maxProgress)
        {
            Invoke("QuestUIOff",1);
        }
    }

    private void QuestUIOff()
    {
        _questButton.AddToClassList("on");
    }

    private void QuestUIOn()
    {
        _questButton.RemoveFromClassList("on");
    }

    public void TriggerQuesManager()
    {

    }
}

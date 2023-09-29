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
        Init();
 
        Invoke("qwer", 3);
    }

    private void Init()
    {
        for (int i = 0; i < QuestSo.QuestSo.Count; i++)
        {
            QuestDic.Add(QuestSo.QuestSo[i].KeyValue, QuestSo.QuestSo[i]);
            QuestDic[QuestSo.QuestSo[i].KeyValue].Clear = false;
        }
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
       
        QuestUIOn();//퀘스트 UI 켜주고
        _currentQuestKey = QuestKeyValue; //현제 키값을 설정해주고
        _currentProgress = QuestDic[_currentQuestKey].MinQuestProgress;
        _maxProgress = QuestDic[_currentQuestKey].MaxQuestProgress;
        _headLabel.text = QuestDic[_currentQuestKey].TitleName;
        _bodyLavel.text = QuestDic[_currentQuestKey].QuestContents+$" {_currentProgress}/{_maxProgress}";
        Debug.Log(_currentQuestKey);


    }

    public void SetProgress()
    {
        _currentProgress++;
        _bodyLavel.text = QuestDic[_currentQuestKey].QuestContents + $" {_currentProgress}/{_maxProgress}";
        if (_currentProgress >= _maxProgress)
        {
            Invoke("QuestUIOff",1);
            QuestDic[_currentQuestKey].Clear = true;
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

using UnityEngine;

[CreateAssetMenu(fileName = "Quest", menuName = "ScriptableObject/Quest")]

public class QuestSO : ScriptableObject
{
    [SerializeField] private string _titleName;public string TitleName { get { return _titleName; } }
    [SerializeField] private int _keyValue; public int KeyValue { get { return _keyValue; } }
    [SerializeField] private string _questContents;public string QuestContents { get { return _questContents; } }
    [SerializeField] private int _maxQuestProgress;public int MaxQuestProgress { get { return _maxQuestProgress; } set { _maxQuestProgress = value; } }
    [SerializeField] private int _minQuestProgress;public int MinQuestProgress { get { return _minQuestProgress; } set { _minQuestProgress = value; } }
    [SerializeField] private bool _clear = false; public bool Clear { get { return _clear; } set { _clear = value; } }
}

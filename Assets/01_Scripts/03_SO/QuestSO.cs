using UnityEngine;

[CreateAssetMenu(fileName = "Quest", menuName = "ScriptableObject/Quest")]

public class QuestSO : ScriptableObject
{
    [SerializeField] private string _titleName;public string TitleName { get { return _titleName; } }
    [SerializeField] private int _keyValue; public int KeyValue { get { return _keyValue; } }
    [SerializeField] private string _questContents;public string QuestContents { get { return _questContents; } }
}

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestSOList",menuName = "ScriptableObject/QuestSOList")]

public class QuestSOList : ScriptableObject 
{
    public List<QuestSO> questSo = new List<QuestSO>();
    
}

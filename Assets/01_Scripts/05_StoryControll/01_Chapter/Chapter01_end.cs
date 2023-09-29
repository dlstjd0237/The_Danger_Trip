
using UnityEngine;
using UnityEngine.SceneManagement;
public class Chapter01_end : Interactable
{
    [SerializeField]
    private string LodingSceneName;
    [Header("끝나는 조건 충족되지 않을때")]
    [SerializeField]
    private string _log;
    private void Awake()
    {
        Debug.Log(QuestManager.Instance.QuestDic[1001].Clear);
        Debug.Log(QuestManager.Instance.QuestDic[1002].Clear);
    }
    protected override void Interact()
    {
        if (QuestManager.Instance.QuestDic[1001].Clear && QuestManager.Instance.QuestDic[1002].Clear)
        {
            FadeImage.Instance.FadeOut(() => SceneManager.LoadScene(LodingSceneName));
        }
        else
        {
            UIManager.Instance.SetDebugText(_log);
        }
    }
}

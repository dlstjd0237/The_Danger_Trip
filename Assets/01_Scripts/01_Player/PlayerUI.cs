using UnityEngine;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _promptText = null;
    // Start is called before the first frame update
   public void UpdateText(string prompt)
    {
        _promptText.text = prompt;
    }
}

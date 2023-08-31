using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class StartControll : MonoBehaviour
{
    [SerializeField] private List<TextMeshPro> Text = new List<TextMeshPro>();
    [SerializeField] private TextMeshProUGUI _toych;
    private Color _cr;
    public void OnText()
    {
        for (int i = 0; i < Text.Count; i++)
        {
            Text[i].fontMaterial.DOFloat(0, ShaderUtilities.ID_FaceDilate, 3);
        }
        StartCoroutine(TextFadeOut());
    }
    private IEnumerator TextFadeOut()
    {
        _cr = _toych.color;
        while (_toych.color.a <= 1)
        {
            _cr.a += Time.deltaTime / 2f;
            _toych.color = _cr;
            yield return null;
        }
        StartCoroutine(TextFadeIn());
    }
    private IEnumerator TextFadeIn()
    {
        _cr = _toych.color;
        while (_toych.color.a >= 0)
        {
            _cr.a -= Time.deltaTime / 2f;
            _toych.color = _cr;
            yield return null;
        }
        StartCoroutine(TextFadeOut());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;
public class StartControll : MonoBehaviour
{
    [SerializeField] private List<TextMeshPro> Text = new List<TextMeshPro>();
    [SerializeField] private TextMeshProUGUI _toych;
    private Color _cr;
    private PlayerInput _playerInput;
    private PlayerInput.FloorActions _onFloor;
    private Animator _animtor;
    private bool endAni = true;
    private int _toychCount = 0;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _onFloor = _playerInput.Floor;
        _animtor = GetComponent<Animator>();
        _onFloor.PrresE.performed += ctx => OnSpace();
    }

    public void OnText()
    {
        _toychCount++;
        endAni = false;
        for (int i = 0; i < Text.Count; i++)
        {
            Text[i].fontMaterial.DOFloat(0, ShaderUtilities.ID_FaceDilate, 3);
        }
        StartCoroutine(TextFadeOut());
    }
    private void OnSpace()
    {       
        if (endAni&&_toychCount == 0)
        {
            _animtor.speed = 200;
        }
        else if (!endAni&& _toychCount>=1)
        {
            FadeImage.Instance.FadeOut(() => { SceneManager.LoadScene(1); });
            endAni = true; 
        }
        _toychCount++;
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
    private void OnEnable()
    {
        _playerInput.Enable();
    }
    private void OnDisable()
    {
        _playerInput.Disable();
    }
}

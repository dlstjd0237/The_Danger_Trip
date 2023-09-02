using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SetDissolveMat : MonoBehaviour
{
    //[SerializeField] private Shader qwer;
    [SerializeField] private List<Renderer> _renderer = new List<Renderer>();
    [SerializeField] private Material _mtrlDissolve;
    [SerializeField] private float _tweeningTime = 3;
    private void Awake()
    {
        for (int i = 0; i < _renderer.Count; i++)
        {
            _renderer[i].material = _mtrlDissolve;

        }

    }
    public void StartMat()
    {
        for (int i = 0; i < _renderer.Count; i++)
        {
            _renderer[i].material.SetFloat("_Cutoff_Height", 0);
            _renderer[i].material.DOFloat(10, "_Cutoff_Height", _tweeningTime);
        }
    }

}

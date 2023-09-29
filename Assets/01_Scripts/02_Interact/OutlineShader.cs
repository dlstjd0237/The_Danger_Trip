using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineShader : MonoBehaviour
{
    private Renderer _renderer;
    private List<Material> materialList = new List<Material>();
    [SerializeField] private Material OutlineMat;
    [HideInInspector]
    public bool Controll = false;
    [HideInInspector]
    public bool Con = false;
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.LookInteract && Controll == true)
        {
            ShaderOff();
        }
    }

    public void ShaderOn()
    {
        if ((GameManager.Instance.LookInteract && Controll == false)&&Con==false)
        {

            materialList.Clear();
            materialList.AddRange(_renderer.sharedMaterials);
            materialList.Add(OutlineMat);
            _renderer.materials = materialList.ToArray();

            Controll = true;
        }



    }
    public void ShaderOff()
    {

        materialList.Clear();
        materialList.AddRange(_renderer.sharedMaterials);
        materialList.Remove(OutlineMat);
        _renderer.materials = materialList.ToArray();
        Controll = false;


    }
}

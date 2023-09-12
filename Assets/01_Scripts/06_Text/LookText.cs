using UnityEngine;
using TMPro;
using DG.Tweening;

[RequireComponent(typeof(CapsuleCollider))]
public class LookText : MonoBehaviour
{
    private Transform _player;
    private TextMeshPro _icon;
    private void Awake()
    {
        _player = GameObject.Find("Player").transform;
        _icon = transform.Find("icon").GetComponent<TextMeshPro>();
    }
    private void Update()
    {
        Look();

    }

    private void Look()
    {
        transform.LookAt(_player);
    }
    private void Show()
    {
        _icon.DOFade(1, 0.5f);
    }
    private void Hidn()
    {
        _icon.DOFade(0, 0.5f);
    }
    public void OnActive()
    {
        gameObject.SetActive(true);
    }
    public void OffActive()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Hidn();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Show();
        }
    }

}

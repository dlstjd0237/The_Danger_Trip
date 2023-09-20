using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Transform _cam;
    private PlayerUI _playerUI;
    private InputManager _inputManager;
    private int _interactMask;
    
    [SerializeField] private float _distance = 2;
    private void Awake()
    {
        _cam = GetComponent<PlayerLook>()._mainCam;
        _interactMask = LayerMask.NameToLayer("Interact");
        _inputManager = GetComponent<InputManager>();
        _playerUI = GetComponent<PlayerUI>();
    }

    void Update()
    {
        _playerUI.UpdateText(string.Empty);
        Ray _ray = new Ray(_cam.transform.position, _cam.transform.forward);
        RaycastHit _hitInfo;
        if (Physics.Raycast(_ray, out _hitInfo, _distance, 1 << _interactMask))
        {
            if (_hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable _interactable = _hitInfo.collider.GetComponent<Interactable>();
                _playerUI.UpdateText(_interactable.promptMessage);
                if(_hitInfo.collider.GetComponent<OutlineShader>()!=null)
                {
                    OutlineShader _outlineShader = _hitInfo.collider.GetComponent<OutlineShader>();
                    GameManager.Instance.LookInteract = true;
                    _outlineShader.ShaderOn();
                }             
                if (_inputManager.OnFloor.PrresE.triggered)
                {
                    _interactable.BassInteract();
                }
            }
           
        }
        else 
        {
            GameManager.Instance.LookInteract = false;
        }
    }
}

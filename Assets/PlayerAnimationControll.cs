using UnityEngine;

public class PlayerAnimationControll : MonoBehaviour
{
    #region �ִϸ��̼� �ؽ�
    //private readonly int Walking = Animator.StringToHash("DI") 
    #endregion

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Walking(Vector3 dir)
    {
        //_animator.SetFloat()
    }
}

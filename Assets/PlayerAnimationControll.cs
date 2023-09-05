using UnityEngine;

public class PlayerAnimationControll : MonoBehaviour
{
    #region �ִϸ��̼� �ؽ�
    private readonly int Walking = Animator.StringToHash("Dir");
    #endregion

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void WalkingAni(Vector3 dir)
    {
       
        _animator.SetFloat(Walking, dir.z);
    }

    public void ReSetAni()
    {
        _animator.SetFloat(Walking, 0);
    }
}

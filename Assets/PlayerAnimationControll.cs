using UnityEngine;

public class PlayerAnimationControll : MonoBehaviour
{
    #region 애니메이션 해싱
    private readonly int DirY = Animator.StringToHash("DirY");
    private readonly int Runing = Animator.StringToHash("IsRun");
    private readonly int DirX = Animator.StringToHash("DirX");
    #endregion

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void WalkingAni(Vector3 dir)
    {
        _animator.SetFloat(DirY, dir.z, .1f, Time.fixedDeltaTime);
        _animator.SetFloat(DirX, dir.x,.1f,Time.fixedDeltaTime);
    }

    public void RunOn()
    {
        _animator.SetBool(Runing, true);
    }
    public void RunOff()
    {
        _animator.SetBool(Runing, false);
    }

    public void ReSetAni()
    {
        _animator.SetFloat(DirY, 0);
        _animator.SetFloat(DirX, 0);
    }
}

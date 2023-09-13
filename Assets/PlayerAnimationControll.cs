using UnityEngine;

public class PlayerAnimationControll : MonoBehaviour
{
    #region 애니메이션 해싱
    private readonly int Walking = Animator.StringToHash("Dir");
    private readonly int Runing = Animator.StringToHash("IsRun");
    private readonly int WalkingX = Animator.StringToHash("DirX");
    #endregion

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void WalkingAni(Vector3 dir)
    {
        Debug.Log(dir.x);
        _animator.SetFloat(Walking, dir.z);
        _animator.SetFloat(WalkingX, dir.x);
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
        _animator.SetFloat(Walking, 0);
        _animator.SetFloat(WalkingX, 0);
    }
}

using UnityEngine;

public class CharacterAnimationController 
{
    private Animator _animator;

    private static int IdleKey = Animator.StringToHash("Idle");
    private static int RunningKey = Animator.StringToHash("Running");
    private static int RightTurnKey = Animator.StringToHash("RightTurn");
    private static int LeftTurnKey = Animator.StringToHash("LeftTurn");
    private static int FallKey = Animator.StringToHash("Fall");
    private static int DanceKey = Animator.StringToHash("Dance");

    public CharacterAnimationController(Animator animator)
    {
        _animator = animator; 
    }

    public void PlayAnimation(AnimationType type)
    {
        switch(type)
        {
            case AnimationType.Idle:
                PlayIdle();
                break;
            case AnimationType.Running:
                PlayRunning();
                break;
            case AnimationType.RightTurn:
                PlayRightTurn();
                break;
            case AnimationType.LeftTurn:
                PlayLeftTurn();
                break;
            case AnimationType.Fall:
                PlayFall();
                break;
            case AnimationType.Dance:
                PlayDance();
                break;
        }
    }

    private void PlayIdle()
    {
        _animator.SetTrigger(IdleKey);
    }

    private void PlayRunning()
    {
        _animator.SetTrigger(RunningKey);
    }

    private void PlayRightTurn()
    {
        _animator.SetTrigger(RightTurnKey);
    }

    private void PlayLeftTurn()
    {
        _animator.SetTrigger(LeftTurnKey);
    }

    private void PlayFall()
    {
        _animator.SetTrigger(FallKey);
    }

    private void PlayDance()
    {
        _animator.SetTrigger(DanceKey);
    }

    
}

using UnityEngine;

public class MentalCalm<TOwner>: MentalBase<TOwner>
{
    private Animator m_animator;

    public MentalCalm(in Animator animator)
    {
        m_animator = animator;
    }

    public override eMentalState GetState()
    {
        return eMentalState.Calm;
    }

    public override bool IaGameOver()
    {
        return true;
    }

    public override void Update(StateMachine<TOwner> stateMachine)
    {
        if (true)
        {
            m_animator.SetBool("isCalm", true);
            m_animator.SetBool("isParanoid", false);
        }
        else if (false)
        {
            m_animator.SetBool("isCalm", false);
            m_animator.SetBool("isParanoid", true);
            stateMachine.ChangeState(eMentalState.Paranoid);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalScared<TOwner> : MentalBase<TOwner>
{
    private Animator m_animator;

    public MentalScared(in Animator animator)
    {
        m_animator = animator;
    }

    public override eMentalState GetState()
    {
        return eMentalState.Scared;
    }

    public override bool IaGameOver()
    {
        return true;
    }

    public override void Update(StateMachine<TOwner> stateMachine)
    {
        if (true)
        {
            m_animator.SetBool("IsParanoid", true);
            m_animator.SetBool("IsScared", false);
            stateMachine.ChangeState(eMentalState.Paranoid);
        }
        else if (false)
        {
            m_animator.SetBool("IsAttacking", true);
            m_animator.SetBool("IsAttacking", false);
        }

    }
}

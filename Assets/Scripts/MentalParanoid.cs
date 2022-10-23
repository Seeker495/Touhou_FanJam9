using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalParanoid<TOwner> : MentalBase<TOwner>
{
    private Animator m_animator;

    public MentalParanoid(in Animator animator)
    {
        m_animator = animator;
    }

    public override eMentalState GetState()
    {
        return eMentalState.Paranoid;
    }

    public override bool IaGameOver()
    {
        return true;
    }

    public override void Update(StateMachine<TOwner> stateMachine)
    {
        if (true)
        {
            m_animator.SetBool("IsCalm", true);
            m_animator.SetBool("IsParanoid", false);
            stateMachine.ChangeState(eMentalState.Calm);
        }
        else if (false)
        {
            m_animator.SetBool("IsParanoid", false);
            m_animator.SetBool("IsScared", true);
            stateMachine.ChangeState(eMentalState.Scared);
        }

    }
}

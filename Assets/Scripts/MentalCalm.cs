using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalCalm<TOwner> : MentalBase<TOwner>
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
            m_animator.SetBool("IsCalm", true);
            m_animator.SetBool("IsParanoid", false);
        }
        else if(false)
        {
            m_animator.SetBool("IsCalm", false);
            m_animator.SetBool("IsParanoid", true);
            stateMachine.ChangeState(eMentalState.Paranoid);
        }
    }
}

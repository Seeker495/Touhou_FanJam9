using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class StateMachine<TOwner>
{
    private TOwner m_owner;
    private MentalBase<TOwner> m_currentMental;
    private Animator m_animator;
    public StateMachine(TOwner owner, MentalBase<TOwner> mental, Animator animator)
    {
        m_owner = owner;
        m_currentMental = mental;
        m_animator = animator;
    }

    public void ChangeState(eMentalState nextState)
    {
        if (m_currentMental.GetState() == nextState) return;


        Dictionary<eMentalState, MentalBase<TOwner>> mentalState = new Dictionary<eMentalState, MentalBase<TOwner>>(3)
        {
            {eMentalState.Calm,new MentalCalm<TOwner>(m_animator) },
            {eMentalState.Paranoid,new MentalParanoid<TOwner>(m_animator) },
            {eMentalState.Scared,new MentalScared<TOwner>(m_animator) },
        };

        m_currentMental = mentalState[nextState];
    }

    public void Update()
    {
        if (m_currentMental == null) return;
        m_currentMental.Update(this);
    }

    public eMentalState GetState()
    {
        return m_currentMental.GetState();
    }


}

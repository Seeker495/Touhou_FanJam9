using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class StateMachine<TOwner>
{
    private TOwner m_owner;
    private MentalBase m_currentMental;
    public StateMachine(TOwner owner, MentalBase mental)
    {
        m_owner = owner;
        m_currentMental = mental;

    }

    public void ChangeState(eMentalState nextState)
    {
        if (m_currentMental.GetState() == nextState) return;

        Dictionary<eMentalState, MentalBase> mentalState = new Dictionary<eMentalState, MentalBase>(3)
        {
            {eMentalState.Calm,new MentalCalm() },
            {eMentalState.Paranoid,new MentalParanoid() },
            {eMentalState.Scared,new MentalScared() },
        };

        m_currentMental = mentalState[nextState];
    }

    public void Update()
    {
        if (m_currentMental == null) return;
        m_currentMental.Update();
    }

    public eMentalState GetState()
    {
        return m_currentMental.GetState();
    }


}

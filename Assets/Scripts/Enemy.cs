using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public StateMachine<Enemy> m_stateMachine;
    private Animator m_animator;
    // Start is called before the first frame update
    void Awake()
    {
        m_animator = GetComponent<Animator>();
        m_stateMachine = new StateMachine<Enemy>(this, new MentalCalm<Enemy>(GetAnimator()), GetAnimator());
        //m_stateMachine.ChangeState(eMentalState.Calm);
    }

    // Update is called once per frame
    void Update()
    {
        m_stateMachine.Update();
    }

    public Animator GetAnimator()
    {
        return m_animator;
    }
}

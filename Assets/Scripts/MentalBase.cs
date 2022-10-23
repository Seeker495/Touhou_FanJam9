using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MentalBase<T>
{
    public abstract void Update(StateMachine<T> stateMachine);
    public abstract eMentalState GetState();
    public abstract bool IaGameOver();
}

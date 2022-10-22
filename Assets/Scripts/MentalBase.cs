using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MentalBase
{
    public abstract void Update();
    public abstract eMentalState GetState();
    public abstract bool IaGameOver();
}

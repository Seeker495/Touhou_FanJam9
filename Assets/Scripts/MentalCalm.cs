using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalCalm : MentalBase
{
    public override eMentalState GetState()
    {
        return eMentalState.Calm;
    }

    public override bool IaGameOver()
    {
        return true;
    }

    public override void Update()
    {

    }
}

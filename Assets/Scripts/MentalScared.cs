using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalScared : MentalBase
{
    public override eMentalState GetState()
    {
        return eMentalState.Scared;
    }

    public override bool IaGameOver()
    {
        return true;
    }

    public override void Update()
    {
    }
}

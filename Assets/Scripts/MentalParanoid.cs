using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalParanoid : MentalBase
{
    public override eMentalState GetState()
    {
        return eMentalState.Paranoid;
    }

    public override bool IaGameOver()
    {
        return true;
    }

    public override void Update()
    {
    }
}

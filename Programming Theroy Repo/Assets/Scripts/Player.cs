using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private void Start()
    {
        MaximumLife = 500;
    }

    protected override void UseHability()
    {
        // Use Hability
    }

    public override void SetMaximumLife(float maximumLife)
    {
        base.SetMaximumLife(maximumLife);
    }
}

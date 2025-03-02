using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character // INHERITANCE
{
    private void Start()
    {
        MaximumLife = 100;

    }
    protected override void UseAbility()
    {
        // Use Ability
    }
}

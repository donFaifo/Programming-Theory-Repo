using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon: Collectible
{
    public override void OnCollect()
    {
        print("Weapon collected");
    }

    
}

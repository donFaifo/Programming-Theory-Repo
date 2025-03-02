using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon: Collectible // INHERITANCE
{
    public override void OnCollect() // POLYMORPHISM
    {
        print("Weapon collected");
    }

    
}

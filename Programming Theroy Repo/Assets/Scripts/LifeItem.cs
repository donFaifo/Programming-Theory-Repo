using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeItem : Collectible // INHERITANCE
{
    public override void OnCollect() // POLYMORPHISM
    {
        print("Life object acquired");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeItem : Collectible
{
    public override void OnCollect()
    {
        print("Life object acquired");
    }
}

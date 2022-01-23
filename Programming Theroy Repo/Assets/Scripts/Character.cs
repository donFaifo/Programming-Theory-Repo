using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public GameObject weapon;
    private float minimumLife = 10f;

    protected float MaximumLife { get; set; }
    protected float Life
    {
        get {
            return Life;
        }
        set {
            if(Life < 0) Life = 0;
            if(Life > MaximumLife) Life = MaximumLife;
        }
    }

    protected abstract void UseHability();

    protected virtual void ReceiveDamage(float damageReceived)
    {
        Life -= damageReceived;
    }

    public virtual void SetMaximumLife(float maximumLife)
    {
        if(maximumLife < minimumLife)
        {
            Debug.Log("Maximum life could not be less than 10");
            return;
        }
        MaximumLife = maximumLife;
    }
}

using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public GameObject weapon;

    protected float Speed;
    protected float RotationSpeed;
    protected float JumpStrength;

    private float minimumLife = 10f;

    protected int MaximumLife { get; set; }
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

    protected virtual void ReceiveDamage(int damageReceived)
    {
        Life -= damageReceived;
    }

    public virtual void SetMaximumLife(int maximumLife)
    {
        if(maximumLife < minimumLife)
        {
            Debug.Log("Maximum life could not be less than 10");
            return;
        }
        MaximumLife = maximumLife;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MonoBehaviour
{

    Collider itemCollider;

    [SerializeField] float rotationSpeed;

    private void Start()
    {
        itemCollider = GetComponent<Collider>();
        itemCollider.isTrigger = true;
    }

    public abstract void OnCollect();

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnCollect();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, Space.World);
    }
}

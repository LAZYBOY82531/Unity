using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] 
    private float bulletSpeed;
    [SerializeField]
    private GameObject boom;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(boom, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

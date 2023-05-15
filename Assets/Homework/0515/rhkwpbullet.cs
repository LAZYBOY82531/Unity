using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rhkwpbullet : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float BS;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * BS;
        Destroy(gameObject, 5f);
    }
}

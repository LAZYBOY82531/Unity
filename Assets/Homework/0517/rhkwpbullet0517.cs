using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rhkwpbullet0517: MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float BS;
    [SerializeField]
    private GameObject boomEppect;

    private void Awake()
    {
        AudioSource boomAudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * BS;
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(boomEppect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

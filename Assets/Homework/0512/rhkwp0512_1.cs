using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rhkwp0512_1 : MonoBehaviour
{
    public float JP;
    Rigidbody rigidbody;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        rigidbody.AddForce(Vector3.up * JP, ForceMode.Impulse);
        Debug.Log("jump");
    }

    public void OnJump(InputValue value)
    {
        Jump();
    }
}

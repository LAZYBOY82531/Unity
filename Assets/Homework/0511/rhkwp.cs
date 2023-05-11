using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class rhkwp : MonoBehaviour
{
    Rigidbody rigidbody;
    public string newName = "Player";

    public int JP = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
        gameObject.name = newName;
    }

    void FixedUpdate()
    {
        Jump();
    }

    // Update is called once per frame
    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * JP, ForceMode.Impulse);
        }
    }
}

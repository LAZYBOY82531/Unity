using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover0518: MonoBehaviour
{
    private Vector3 moveDir;
    private Rigidbody rb;
    public float movePower;
    public float rotatePower;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Move();
        Rotate();
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * moveDir.z * movePower * Time.deltaTime, Space.Self);
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotatePower * Time.deltaTime, Space.Self);
    }


    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
        Debug.Log(moveDir);
    }
}

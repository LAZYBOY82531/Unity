using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    private Vector3 moveDir;
    private Rigidbody rb;
    public float movePower;
    public float jumpPower;
    public float rotatePower;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Move();
        Rotate();
        //LookAt();
        //Jump();
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * moveDir.z * movePower * Time.deltaTime, Space.Self);
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotatePower * Time.deltaTime, Space.Self);
    }

    public void LookAt()
    {
        transform.LookAt(new Vector3(0, 0, 0));
    }

    public void Rotation()
    {
        
    }

    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x; 
        moveDir.z = value.Get<Vector2>().y;
        Debug.Log(moveDir);
    }
    public void OnJump(InputValue value)
    {
        moveDir.y = value.Get<Vector3>().z;
        Debug.Log(moveDir);
    }
}

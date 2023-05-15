using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rhkwp0515 : MonoBehaviour
{
    private Vector3 moveDir;
    private Rigidbody rb;
    [SerializeField]
    private float movePower;
    [SerializeField]
    private float rotatePower;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform bulletPoint;
    [SerializeField]
    private Transform bulletPoint2;
    [SerializeField]
    private float repeatTime;


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
        transform.Translate(Vector3.forward * moveDir.y * movePower * Time.deltaTime, Space.Self);
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.left, moveDir.x * rotatePower * Time.deltaTime, Space.Self);
    }


    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.y = value.Get<Vector2>().y;
        Debug.Log(moveDir);
    }

    private Coroutine bulletRoutine;

    private void OnFire(InputValue value)
    {
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Instantiate(bulletPrefab, bulletPoint2.position, bulletPoint2.rotation);
    }

    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            Instantiate(bulletPrefab, bulletPoint2.position, bulletPoint2.rotation);
            yield return new WaitForSeconds(repeatTime);
        }
    }

    private void OnRapidFire(InputValue value)
    {
        if (value.isPressed)
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
        }
        else
        {
            StopCoroutine(bulletRoutine);
        }
    }
}

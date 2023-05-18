using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerShooter0518 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletPoint;
    public float repeatTime;
    public Animator animator;

    public UnityEvent OnFired;


    private Coroutine bulletRoutine;

    public void Fire()
    {
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        animator.SetTrigger("Fire");
        GameManager0518.Data.AddShootCount(1);
        OnFired?.Invoke();
    }

    private void OnFire(InputValue value)
    {
        Fire();
    }

    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Fire();
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

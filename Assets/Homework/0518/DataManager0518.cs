using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager0518 : MonoBehaviour
{
    public int shootCount0518;

    public UnityAction<int> OnShootChanged0518;

    public void AddShootCount(int count)
    {
        shootCount0518 += count;
        OnShootChanged0518?.Invoke(shootCount0518);
    }
}

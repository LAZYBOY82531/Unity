using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Count0518 : MonoBehaviour
{
    private TMP_Text textView;

    private void Awake()
    {
        textView = GetComponent<TMP_Text>();
        ChangeText(GameManager0518.Data.shootCount0518);
    }

    private void OnEnable()
    {
        GameManager0518.Data.OnShootChanged0518 += ChangeText;
    }

    private void OnDisable()
    {
        GameManager0518.Data.OnShootChanged0518 -= ChangeText;
    }

    private void ChangeText(int count)
    {
        textView.text = count.ToString();
    }
}

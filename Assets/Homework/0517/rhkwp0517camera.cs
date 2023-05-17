using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class rhkwp0517camera : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera Camera;

    private void OnMoveCamera(InputValue value)
    {
        if (Camera.Priority == 5)
        {
            Camera.Priority = 15;
        }
        else
        {
            Camera.Priority = 5;
        }
    }
}

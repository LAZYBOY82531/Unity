using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager0518 : MonoBehaviour
{
    private static GameManager0518 instance;
    public static DataManager0518 DM;

    public static GameManager0518 Instance { get { return instance; } }
    public static DataManager0518 Data { get { return DM; } }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        InitDataManager();
        DontDestroyOnLoad(this);
        instance = this;
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

    private void InitDataManager()
    {
        GameObject dataObj = new GameObject() { name = "DataManager0518" };
        dataObj.transform.SetParent(transform);
        DM = dataObj.AddComponent<DataManager0518>();
    }
}

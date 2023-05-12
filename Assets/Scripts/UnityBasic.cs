using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnityBasic : MonoBehaviour
{
    public AudioSource audioSource;
    
    private void Start()
    {
        GameObjectBasic();
        ComponentBasic();
    }
    public void GameObjectBasic()
    {
        //<���ӿ�����Ʈ ����>
        //������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���

        //������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
        //gameObject.name;                 // ���ӿ�����Ʈ�� �̸� ����
        //gameObject.active;         // ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
        //gameObject.tag;                   // ���ӿ�����Ʈ�� �±� ����
        //gameObject.layer;               // ���ӿ�����Ʈ�� ���̾� ����

        GameObject ob = GameObject.Find("Player");
        GameObject.FindGameObjectWithTag("Player");
        GameObject.FindGameObjectsWithTag("Player");

        //���ӿ�����Ʈ ����
        GameObject newObject = new GameObject("New GameObject");

        //���ӿ�����Ʈ ����
        Destroy( gameObject, 5f);
    }
    public void ComponentBasic()
    {
        //<���ӿ�����Ʈ �� ������Ʈ ����>
        GetComponent<AudioSource>();
        GetComponents<AudioSource>();
        //������Ʈ���� GetComponent �� ����� ��� �پ��ִ� ������Ʈ �������� ����
        gameObject.GetComponent<AudioSource>();    //���ӿ�����Ʈ�� ������Ʈ ����
        gameObject.GetComponents<AudioSource>();    //���ӿ�����Ʈ�� ���� ������Ʈ ����

        GetComponentInChildren<Rigidbody>();    //�ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        GetComponentsInChildren<Rigidbody>();   //�ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        gameObject.GetComponentInParent<Rigidbody>();    //���ӿ�����Ʈ�� �θ���ӿ�����Ʈ ���� ������Ʈ ����
        gameObject.GetComponentsInParent<Rigidbody>();    //���ӿ�����Ʈ�� �θ���ӿ�����Ʈ ���� ���� ������Ʈ ����

        // <������Ʈ Ž��>
        FindObjectOfType<AudioSource>();         //�� ���� ������Ʈ Ž��  ;
        FindObjectsOfType<AudioSource>();        //�� ���� ��� ������Ʈ Ž��;

        //<������Ʈ �߰�>
        //Rigibody rigid = new Rigibody();         ������ �ϳ� �ǹ̾���, 
        AudioSource source = gameObject.AddComponent<AudioSource>();

        //������Ʈ����
        Destroy(GetComponent<Collider>());
    }
}

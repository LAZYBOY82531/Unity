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
        //<게임오브젝트 접근>
        //컴포넌트가 붙어있는 게임오브젝트는 gameObject 속성을 이용하여 접근가능

        //컴포넌트가 붙어있는 게임오브젝트
        //gameObject.name;                 // 게임오브젝트의 이름 접근
        //gameObject.active;         // 게임오브젝트의 활성화 여부 접근
        //gameObject.tag;                   // 게임오브젝트의 태그 접근
        //gameObject.layer;               // 게임오브젝트의 레이어 접근

        GameObject ob = GameObject.Find("Player");
        GameObject.FindGameObjectWithTag("Player");
        GameObject.FindGameObjectsWithTag("Player");

        //게임오브젝트 생성
        GameObject newObject = new GameObject("New GameObject");

        //게임오브젝트 삭제
        Destroy( gameObject, 5f);
    }
    public void ComponentBasic()
    {
        //<게임오브젝트 내 컴포넌트 접근>
        GetComponent<AudioSource>();
        GetComponents<AudioSource>();
        //컴포넌트에서 GetComponent 를 사용할 경우 붙어있는 오브젝트 기준으로 들고옴
        gameObject.GetComponent<AudioSource>();    //게임오브젝트의 컴포넌트 접근
        gameObject.GetComponents<AudioSource>();    //게임오브젝트의 여러 컴포넌트 접근

        GetComponentInChildren<Rigidbody>();    //자식게임오브젝트 포함 컴포넌트 접근
        GetComponentsInChildren<Rigidbody>();   //자식게임오브젝트 포함 여러 컴포넌트 접근
        gameObject.GetComponentInParent<Rigidbody>();    //게임오브젝트의 부모게임오브젝트 포함 컴포넌트 접근
        gameObject.GetComponentsInParent<Rigidbody>();    //게임오브젝트의 부모게임오브젝트 포함 여러 컴포넌트 접근

        // <컴포넌트 탐색>
        FindObjectOfType<AudioSource>();         //씬 내의 컴포넌트 탐색  ;
        FindObjectsOfType<AudioSource>();        //씬 내의 모든 컴포넌트 탐색;

        //<컴포넌트 추가>
        //Rigibody rigid = new Rigibody();         가능은 하나 의미없슴, 
        AudioSource source = gameObject.AddComponent<AudioSource>();

        //컴포넌트삭제
        Destroy(GetComponent<Collider>());
    }
}

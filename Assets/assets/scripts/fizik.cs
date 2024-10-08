using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fizik : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 vec = Vector3.forward;
            //Vector3 vec = Vector3.up;
            //Vector3 vec = Vector3.right;


            rigid.AddForce(vec * 5);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Enter");
        GameObject go = collision.gameObject;
        Debug.Log(go);
    }

    private void OnCollisionStay(Collision collision) //rigidbody ve collider gerekiyor kullanmak için
    {
        Debug.Log("Stay");

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }



}

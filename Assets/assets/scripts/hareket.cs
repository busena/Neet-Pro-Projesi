using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class hareket : MonoBehaviour
{
    //float z = 0.0f;
    //float x = 0.0f;
    //float y = 0.0f;

    Transform tr;
    Vector3 pos = new Vector3(0, 0, 0);
    public float hiz = 0f;
    public float MouseSens = 2f;

    float yol;
    void Start()
    {
        tr = GetComponent<Transform>();
        //string metin = gameObject.name;
        //Debug.Log(metin);
        //Transform tr = GetComponent<Transform>();
        //Vector3 pos = tr.position;
        //Debug.Log(pos);
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float axisX = Input.GetAxis("Mouse X") * MouseSens;
            float axisY = Input.GetAxis("Mouse Y") * MouseSens;

            //Debug.Log(axisX);
            //Debug.Log(axisY);

            Quaternion q = transform.rotation;
            Vector3 rot = q.eulerAngles;

            rot.x -= axisY;
            rot.y += axisX;
            //Vector3 rot = new Vector3(0, axisX, 0); 
            Quaternion q2 = Quaternion.Euler(rot);
            transform.rotation = q2;


            yol = hiz * Time.deltaTime;
            pos = tr.position;

            //main karakterin position bilgisi alýnýp oradan oynanmaya baþlýyor.
            //x = pos.x;
            //y = pos.y;
            //z = pos.z;

            if (Input.GetKey(KeyCode.W))
            {
                Vector3 vec = Vector3.forward;
                vec = q2 * vec;
                pos = pos + vec * yol;
                
                //z = z + hiz;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Vector3 vec = Vector3.back;
                vec = q2 * vec;
                pos = pos + vec * yol;
                //z = z - hiz;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 vec = Vector3.right;
                vec = q2 * vec;
                pos = pos + vec * yol;
                //x = x + hiz;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Vector3 vec = Vector3.left;
                vec = q2 * vec;
                pos = pos + vec * yol;
                //x = x - hiz;
            }
            if (Input.GetKey(KeyCode.E))
            {
                Vector3 vec = Vector3.up;
                vec = q2 * vec;
                pos = pos + vec * yol;
                //y = y + hiz;

            }
            else if (Input.GetKey(KeyCode.Q))
            {
                Vector3 vec = Vector3.down;
                vec = q2 * vec;
                pos = pos + vec * yol;
                //y = y - hiz;
            }


            //pos.z = z;
            //pos.x = x;
            //pos.y = y;
            tr.position = pos;
        }
    }
}

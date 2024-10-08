using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereCircle : MonoBehaviour
{
    public float capUzunluk = 10.0f;
    public int kureSayisi = 10;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 cap = Vector3.up * capUzunluk;

        for (int i = 0; i < kureSayisi; i++)
        {
            Vector3 rot = new Vector3(0, 0, 360 / (float) kureSayisi * i);
            Quaternion q = Quaternion.Euler(rot);
            
            Vector3 sonuc = q * cap;

            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position = sonuc;
        }


    }


    // Update is called once per frame
    void Update()
    {

    }
}

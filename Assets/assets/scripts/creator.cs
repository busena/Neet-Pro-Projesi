using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creator : MonoBehaviour
{
    public int objectCount = 0;
    public GameObject PrefabObj;
    // Start is called before the first frame update
    void Start()
    {
        //Random.Range(1, 100);
        for (int i = 0; i < objectCount; i++)
        {
            GameObject go = Instantiate(PrefabObj);
            go.name = "Balon" + i;
            //GameObject go = GameObject.CreatePrimitive(PrimitiveType.Capsule); 
            //go.name = "buze" + i;

            //Transform tr = go.GetComponent<Transform>();
            float x = Random.Range(-20, 20);
            float y = Random.Range(0, 45);
            float z = Random.Range(0, 45);

            go.transform.position = new Vector3(x, y, z); //bu þekilde de transform unu alabiliyoruz. kodun düzgün hali tr.transform
            //go.transform.localScale = new Vector3(7, 7, 7);

            MeshRenderer renderer = go.GetComponent<MeshRenderer>();
            Material mat = renderer.material;
            mat.color = Random.ColorHSV();

            //Rigidbody rb = go.AddComponent<Rigidbody>();
            //rb.useGravity = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

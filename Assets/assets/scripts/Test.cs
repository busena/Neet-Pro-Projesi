using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject go;
    public MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        //string name = gameObject.name;
        //Debug.Log(name);
        //gameObject.SetActive(false);
        //MeshFilter filter = GetComponent<MeshFilter>();
        //Mesh cub = filter.mesh;
        //MeshRenderer renderer = GetComponent<MeshRenderer>();
        //Material mat = renderer.material;
        //mat.color = Random.ColorHSV();

        //BoxCollider col = GetComponent<BoxCollider>(); //burada cube'ün boxcollider'ýný center'lýyo
        //Vector3 newCenter = new Vector3(1, 2, 3);
        //col.center = newCenter;

        //gameObject.AddComponent<Rigidbody>();
        //Rigidbody rigid = gameObject.AddComponent<Rigidbody>(); //bu sekilde de cagirilabilir


        //GameObject go = GameObject.Find("RightCube");
        //MeshRenderer renderer = go.GetComponent<MeshRenderer>();
        Material mat = renderer.material;
        mat.color = Color.magenta;

        //go.SetActive(false);
        Transform tr = go.GetComponent<Transform>();

        Vector3 pos = tr.position;
        pos.y = pos.y + 2;
        tr.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Burasý update.");
    }
}

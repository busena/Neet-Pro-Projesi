using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vec = new Vector3(1, 2, 3);
        Vector3 vec2 = Vector3.zero;

        vec = vec2;
        vec = new Vector3(10, 3, 5);
        vec.x = 5;
        vec.y = 10;

        vec2 = Vector3.forward;
        vec2 = Vector3.down;
        vec2 = Vector3.one;
        vec2 = Vector3.right;

    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creator2 : MonoBehaviour
{
    public GameObject hedef;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(hedef);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

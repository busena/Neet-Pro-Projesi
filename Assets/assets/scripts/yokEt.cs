
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokEt : MonoBehaviour
{
    public AudioSource balonSound;

    void Start()
    {
        balonSound = GetComponent<AudioSource>();
    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(gameObject); 
    //}



    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        if (name.Contains("bullet"))
        {
            Destroy(gameObject, 2f);

            GameObject go = GameObject.Find("Manager");

            ScoreCounter counter = go.GetComponent<ScoreCounter>();
            //counter.Score++;
            counter.ScoreIncrement();

            balonSound.Play();

            MeshRenderer balon = GetComponent<MeshRenderer>();
            balon.enabled = false;

            Collider collider = GetComponent<Collider>();
            collider.enabled = false;
        
        }


    }

    void Update()
    {
        
    }
}

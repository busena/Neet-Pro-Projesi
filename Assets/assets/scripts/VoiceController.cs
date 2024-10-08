using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceController : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space ))
        {
            if (source.isPlaying)
            {
                source.Pause();
            }
            else
            {
                source.Play();
            }
        }

        //if(Input.GetKeyUp(KeyCode.P))
        //{
        //    source.Pause();
        //}

        //if (Input.GetKeyUp(KeyCode.S))
        //{
        //    source.Stop();
        //}
    }
}

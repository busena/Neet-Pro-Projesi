using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using static Unity.VisualScripting.Member;

public class VideoController : MonoBehaviour
{
    VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (player.isPlaying)
            {
                player.Pause();
            }
            else
            {
                player.Play();
            }
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            player.Stop();
        }
    }
}


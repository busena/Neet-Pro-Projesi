using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

public class odevCuma : MonoBehaviour
{
    //public TMP_Text text;
    VideoPlayer player;
    public Button playButton;
    public Button stopButton;
    public Sprite PauseSprite;
    Sprite PlaySprite;
    public Image ButtonImage;


    void Start()
    {
        player = GetComponent<VideoPlayer>();
        PlaySprite = ButtonImage.sprite;

        if (player.playOnAwake)
        {
            //text.text = "Pause";
        }
        else
        {
            //text.text = "Play";
        }
    }

    public void PlayVideo()
    {
        if (player.isPlaying)
        {
            player.Pause();
            //text.text = "Play";
            ButtonImage.sprite = PlaySprite;   

        }
        else
        {
            player.Play();
            //text.text = "Pause";
         }
    }
    public void StopVideo()
    {
        player.Stop();
        player.time = 0;
        ButtonImage.sprite = PlaySprite;
        //text.text = "Play";
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            PlayVideo();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            StopVideo();
        }
    }
}


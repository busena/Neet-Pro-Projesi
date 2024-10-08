using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public int Score = 0;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Score);
    }

    public void ScoreIncrement()
    {
        Score = Score + 1;
        scoreText.text = Score.ToString();
        Debug.Log(Score);
    }
}

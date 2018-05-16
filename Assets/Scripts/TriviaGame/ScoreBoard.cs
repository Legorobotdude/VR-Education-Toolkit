using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public float Score { get; set;}

    [Header("0 for unlimited time")] [SerializeField]
    float maxTimeBeforeFailure = 0;

    [SerializeField] private TextMesh scoreText;
    [SerializeField] private TextMesh timerText;

    private float timeSinceLastAnswer;
    private float lastAnswerTimeStamp;

    // Use this for initialization
    void Start()
    {
        lastAnswerTimeStamp = Time.time;
        if (scoreText == null)
        {
            scoreText = GetComponentInChildren<TextMesh>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (maxTimeBeforeFailure != 0)
        {
            if ((Time.time - lastAnswerTimeStamp) > maxTimeBeforeFailure)
            {
                //Fail
                print("Times up!");
            }
        }
        //Update Timer
        timerText.text = (maxTimeBeforeFailure - (Time.time - lastAnswerTimeStamp)).ToString();
    }

    public void IncreaseScore()
    {
        if (maxTimeBeforeFailure == 0)
        {
            Score += 100*(float) Math.Pow(Convert.ToSingle(Math.E), -(Time.time - lastAnswerTimeStamp));
        }
        else
        {
            Score += maxTimeBeforeFailure - (Time.time - lastAnswerTimeStamp);
        }

        lastAnswerTimeStamp = Time.time;
        scoreText.text = Score.ToString();
    }
}
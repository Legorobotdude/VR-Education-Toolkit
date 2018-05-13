using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathQuestion : Question
{
    [SerializeField] private int maxNumber = 10;

    // Use this for initialization
    void Start()
    {
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {
    }

    protected override void GenerateQuestion()
    {
        string questionText = "";
        questionText += Random.Range(0, maxNumber).ToString();
        switch (Random.Range(0, 3))
        {
            case 0:
                questionText += "+";
                break;
            case 1:
                questionText += "-";
                break;
            case 2:
                questionText += "*";
                break;
            case 3:
                questionText += "/";
                break;
        }
        questionText += Random.Range(0, maxNumber).ToString();
        questionText += "=?";

        QuestionText.text = questionText;
    }
}
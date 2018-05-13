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
        int firstNumber = Random.Range(0, maxNumber);
        int secondNumber = Random.Range(0, maxNumber);
        int operatorType = Random.Range(0, 3);

        int answer;
        
        questionText += firstNumber.ToString();
        
        switch (operatorType)
        {
            case 0:
                questionText += "+";
                answer = firstNumber + secondNumber;
                break;
            case 1:
                questionText += "-";
                answer = firstNumber - secondNumber;
                break;
            case 2:
                questionText += "*";
                answer = firstNumber * secondNumber;
                break;
            case 3:
                questionText += "/";
                answer = firstNumber / secondNumber;
                break;
            default:
                answer = 0;
                break;
        }

        
        questionText += secondNumber.ToString();
        questionText += "=?";

        QuestionText.text = questionText;
        SetAnswers(answer,firstNumber,secondNumber);
    }

    protected void SetAnswers(int answer, int firstNumber, int secondNumber)
    {
        
        int correctAnswerIndex = Random.Range(0, Answers.Length);
        for (int i = 0; i < Answers.Length; i++)
        {
            if (i == correctAnswerIndex)
            {
                Answers[i].AnswerText.text = answer.ToString();
            }
            else
            {
                switch (Random.Range(0,4))
                {
                      default:break;  
                }
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MathQuestion : Question
{
    [SerializeField] private int maxNumber = 10;
    [SerializeField] private int answerVariance = 2;

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
        SetAnswers(answer, firstNumber, secondNumber, operatorType);
    }

    protected void SetAnswers(int answer, int firstNumber, int secondNumber, int operatorType)
    {
        int correctAnswerIndex = Random.Range(0, Answers.Length);
        for (int i = 0; i < Answers.Length; i++)
        {
            if (i == correctAnswerIndex)
            {
                Answers[i].AnswerText.text = answer.ToString();
                Answers[i].IsAnswer = true;
            }
            else
            {
                switch (operatorType)
                {
                    case 0:

                        Answers[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) +
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    case 1:

                        Answers[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) -
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    case 2:

                        Answers[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) *
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    case 3:

                        Answers[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) /
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    default:
                        break;
                }

                if (Answers[i].AnswerText.text == answer.ToString())
                {
                    Answers[i].AnswerText.text = (Int32.Parse(Answers[i].AnswerText.text) + Random.Range(-answerVariance,answerVariance)).ToString();
                }
            }
        }
    }
}
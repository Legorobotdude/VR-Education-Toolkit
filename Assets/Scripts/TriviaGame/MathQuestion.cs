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

    public override void GenerateQuestion()
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
        scoreBoard.IncreaseScore();
    }

    protected void SetAnswers(int answer, int firstNumber, int secondNumber, int operatorType)
    {
        int correctAnswerIndex = Random.Range(0, AnswerObjects.Length);
        for (int i = 0; i < AnswerObjects.Length; i++)
        {
            if (i == correctAnswerIndex)
            {
                AnswerObjects[i].AnswerText.text = answer.ToString();
                AnswerObjects[i].IsAnswer = true;
            }
            else
            {
                AnswerObjects[i].IsAnswer = false;
                switch (operatorType)
                {
                    case 0:

                        AnswerObjects[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) +
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    case 1:

                        AnswerObjects[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) -
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    case 2:

                        AnswerObjects[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) *
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    case 3:

                        AnswerObjects[i].AnswerText.text =
                            ((firstNumber + Random.Range(-answerVariance, answerVariance)) /
                             (secondNumber + Random.Range(-answerVariance, answerVariance))).ToString();
                        break;
                    default:
                        break;
                }

                if (Int32.Parse(AnswerObjects[i].AnswerText.text) == answer)
                {
                    switch (Random.Range(0,1))
                    {
                            case 0:
                                AnswerObjects[i].AnswerText.text = (Int32.Parse(AnswerObjects[i].AnswerText.text) + Random.Range(1,answerVariance)).ToString();
                                break;
                            case 1:
                                AnswerObjects[i].AnswerText.text = (Int32.Parse(AnswerObjects[i].AnswerText.text) - Random.Range(1,answerVariance)).ToString();
                                break;
                                
                    }
                    
                }
            }
        }
    }
}
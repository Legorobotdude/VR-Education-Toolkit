using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriviaQuestion : Question
{

	[SerializeField] private string[] questions;
	[SerializeField] private string[] answers;

	
	// Use this for initialization
	void Start () {
		GenerateQuestion();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public override void GenerateQuestion()
	{
		int questionIndex = Random.Range(0, questions.Length);
		QuestionText.text = questions[questionIndex];
		SetAnswers(questionIndex);
	}

	protected void SetAnswers(int correctAnswerIndex)
	{
		int correctAnswerPos = Random.Range(0, AnswerObjects.Length);
		for (int i = 0; i < AnswerObjects.Length; i++)
		{
			if (i == correctAnswerPos)
			{
				AnswerObjects[i].AnswerText.text = answers[correctAnswerIndex];
			}
			else
			{
				int randomAnswerIndex;
				do
				{
					randomAnswerIndex = Random.Range(0, answers.Length);
				} while (correctAnswerIndex == randomAnswerIndex);

				AnswerObjects[i].AnswerText.text = answers[randomAnswerIndex];

			}
			
		}
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{

	public TextMesh AnswerText;
	public bool IsAnswer = false;
	public Question Question;

	private void Start()
	{
		if (AnswerText == null)
		{
			AnswerText = GetComponentInChildren<TextMesh>();
		}

		if (Question == null)
		{
			Question = GetComponentInParent<Question>();
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.GetComponent<Bullet>() != null)
		{
			if (IsAnswer)
			{
				//Score++
				//Calculate score based on time used to answer question
				Question.GenerateQuestion();
			}
			else
			{
				//GameOver
			}
			
			//question.GenerateQuestion();
		}
	}
}

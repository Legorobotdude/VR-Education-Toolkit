using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{

	public TextMesh AnswerText;
	public bool IsAnswer = false;

	private void Start()
	{
		if (AnswerText == null)
		{
			AnswerText = GetComponentInChildren<TextMesh>();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{

	public TextMesh AnswerText;

	private void Start()
	{
		if (AnswerText == null)
		{
			AnswerText = GetComponentInChildren<TextMesh>();
		}
	}
}

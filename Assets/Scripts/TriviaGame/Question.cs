﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Question : MonoBehaviour
{

	[SerializeField] protected TextMesh QuestionText;
	[SerializeField] protected Answer[] AnswerObjects;
	[SerializeField] protected ScoreBoard scoreBoard;

	public abstract void GenerateQuestion();


}

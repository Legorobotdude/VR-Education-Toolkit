﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Question : MonoBehaviour
{

	[SerializeField] protected TextMesh QuestionText;
	[SerializeField] protected GameObject[] Answers;

	protected abstract void GenerateQuestion();


}

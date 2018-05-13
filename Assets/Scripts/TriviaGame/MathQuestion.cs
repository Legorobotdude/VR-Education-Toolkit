using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathQuestion : Question {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected override void GenerateQuestion()
	{
		QuestionText.text = "This is your question";
	}
}

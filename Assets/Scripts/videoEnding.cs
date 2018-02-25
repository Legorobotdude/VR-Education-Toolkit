using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class videoEnding : MonoBehaviour {

	public float endingTime = 100f;
	public GameObject sceneObjects;
	//Component videoPlayer;
	 private VideoPlayer videoPlayer;
	// Use this for initialization
	void Start () {
	
	}
	
	void Awake()
	{
		  videoPlayer = GetComponent<VideoPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
			
		if (videoPlayer.time == endingTime)
		{
			sceneObjects.SetActive(true);
		}
	}
}

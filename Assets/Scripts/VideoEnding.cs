using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;


public class VideoEnding : MonoBehaviour {

    [SerializeField] double endingTime = 100;
    [SerializeField] GameObject[] objectsToDeactivate;
    [SerializeField] GameObject[] objectsToActivate;
	private VideoPlayer videoPlayer;
    [SerializeField] UnityEvent EventsOnEnding;


    void Awake()
	{
		  videoPlayer = GetComponent<VideoPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
			
		if (videoPlayer.time >= endingTime)
		{
            EventsOnEnding.Invoke();

            for (int i = 0; i < objectsToDeactivate.Length; i++)
            {
                objectsToDeactivate[i].SetActive(false);
            }

            for (int i = 0; i < objectsToActivate.Length; i++)
            {
                objectsToActivate[i].SetActive(true);
            }
            
        }
	}
}

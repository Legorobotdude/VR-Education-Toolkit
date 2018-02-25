using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour {


	[SerializeField] ParticleSystem explosionParticles;
	[SerializeField] GameObject particles;
	[SerializeField] GameObject otherBalloon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collision)
    {
		Debug.Log("enter");
		if (collision.tag == "fire")
		{
			explosionParticles.Play();
			particles.SetActive(true);
			GetComponent<Renderer>().enabled = false;
			otherBalloon.GetComponent<Renderer>().enabled = false;
			//gameObject.SetActive(false);
		}
	}

}

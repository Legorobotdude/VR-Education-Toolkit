using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionEvent : MonoBehaviour {


	[SerializeField] ParticleSystem explosionParticles;
	[SerializeField] GameObject particles;
	[SerializeField] GameObject selfRenderer;
	[SerializeField] GameObject otherBalloon;

	// Use this for initialization
	void Start () {
		
	}
	
	
	void OnTriggerEnter(Collider collision)
    {
		
		if (collision.tag == "fire")
		{
			explosionParticles.Play();
			particles.SetActive(true);
			//GetComponent<Renderer>().enabled = false;
			otherBalloon.GetComponent<Renderer>().enabled = false;
			selfRenderer.GetComponent<Renderer>().enabled = false;
			//gameObject.SetActive(false);
		}
	}

}

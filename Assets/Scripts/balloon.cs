using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour {


	[SerializeField] ParticleSystem explosionParticles;
	[SerializeField] GameObject particles;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision)
    {
		if (collision.collider.tag == "fire")
		{
			explosionParticles.Play();
			particles.SetActive(true);
			gameObject.SetActive(false);
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidPouring : MonoBehaviour {

    [SerializeField] ParticleSystem liquidParticleSystem;
   
    [SerializeField] GameObject liquidObject;

    private Transform myTransform;
    private Renderer liquidRend;
    private ParticleSystem.EmissionModule emission;

    // Use this for initialization
    void Start () {
        emission = liquidParticleSystem.emission;
        emission.enabled = false;
        myTransform = transform;
        liquidRend = liquidObject.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Dot(myTransform.up, Vector3.down) > 0)
        {
            //liquidParticleSystem.Play();
            emission.enabled = true;
        }
        else
        {
            //liquidParticleSystem.Pause();
            emission.enabled = false;
        }

    }
}

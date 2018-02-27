using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour {

    [SerializeField] Vector3 movementVector;

   float movementFactor;//0 for not moved, 1 for fully moved

    [SerializeField] float period;

    Vector3 startingPos;
    


    // Use this for initialization
    void Start ()
    {
        startingPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (period <= Mathf.Epsilon)
        {
            return;
        }
        float cycles = Time.time / period;

        const float tau = 2 * Mathf.PI;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = rawSinWave / 2f + 0.5f;

        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPos + offset;

	}
}

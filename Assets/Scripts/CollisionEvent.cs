﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour {


		
    [SerializeField] GameObject[] objectsToDeactivate;
    [SerializeField] GameObject[] objectsToActivate;
    [SerializeField] string tagToInteract;
    [SerializeField] UnityEvent EventsOnCollision;
    [SerializeField] UnityEvent EventsOnReset;
    [SerializeField] bool oneTimeOnlyEvent = true;
    bool alreadyHappened = false;

	
	
	void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.tag);//Uncomment to get logs of events
        //Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == tagToInteract && alreadyHappened == false)
		{
            if (oneTimeOnlyEvent)
            {
                alreadyHappened = true;
            }

            EventsOnCollision.Invoke();

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

    public void Reset()
    {
        alreadyHappened = false;
        EventsOnReset.Invoke();

        for (int i = 0; i < objectsToDeactivate.Length; i++)
        {
            objectsToDeactivate[i].SetActive(true);
        }

        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(false);
        }
    }

}

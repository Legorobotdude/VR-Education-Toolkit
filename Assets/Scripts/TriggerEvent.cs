using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {


		
    [SerializeField] GameObject[] objectsToDeactivate;
    [SerializeField] GameObject[] objectsToActivate;
    [SerializeField] string tagToInteract;
    bool flag = false;

	
	
	void OnTriggerEnter(Collider collision)
    {
		
		if (collision.tag == tagToInteract && flag == false)
		{
            flag = true;
            for (int i = 0; i < objectsToDeactivate.Length; i++)
            {
                objectsToDeactivate[i].SetActive(false);
            }
            for (int i = 0; i < objectsToActivate.Length; i++)
            {
                objectsToActivate[i].SetActive(true);
            }
            
			//particles.SetActive(true);
			//GetComponent<Renderer>().enabled = false;
			//otherBalloon.GetComponent<Renderer>().enabled = false;
			//selfRenderer.GetComponent<Renderer>().enabled = false;
			//gameObject.SetActive(false);
		}
	}

}

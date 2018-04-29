using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour {


		
    [SerializeField] GameObject[] objectsToDeactivate;
    [SerializeField] GameObject[] objectsToActivate;
    [SerializeField] string tagToInteract;
    [SerializeField] UnityEvent EventsOnCollision;
    [SerializeField] bool oneTimeOnlyEvent = true;
    bool flag = false;

	
	
	void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.tag);//Uncomment to get logs of events
        //Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == tagToInteract && flag == false)
		{
            if (oneTimeOnlyEvent)
            {
                flag = true;
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

}

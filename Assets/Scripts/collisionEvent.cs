using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour {


		
    [SerializeField] GameObject[] objectsToDeactivate;
    [SerializeField] GameObject[] objectsToActivate;
    [SerializeField] string tagToInteract;
    bool flag = false;

	
	
	void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
		if (collision.gameObject.tag == tagToInteract && flag == false)
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
           
		}
	}

}

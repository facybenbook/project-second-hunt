 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupRocket: MonoBehaviour {
	
	
     void OnTriggerEnter(Collider other) {
		GameObject go = GameObject.Find("rockettext");
		TextChange txtchange = go.GetComponent<TextChange>();
        txtchange.health++;
		
		
		

        Destroy(gameObject);
     }
 }
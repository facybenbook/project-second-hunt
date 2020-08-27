 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupAmmo: MonoBehaviour {
	
	
     void OnTriggerEnter(Collider other) {
		//GameObject go = GameObject.Find("ammotext");
		//TextChange txtchange = go.GetComponent<TextChange>();
        //txtchange.health++;
		
		
		

        Destroy(gameObject);
     }
 }
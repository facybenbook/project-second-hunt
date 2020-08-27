 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupRocket: MonoBehaviour {
	
	
     void OnTriggerEnter(Collider other) {
		GameObject go = GameObject.Find("rockettext");
		TextChange_Rocket txtchange = go.GetComponent<TextChange_Rocket>();
        txtchange.health++;
		
		
		

        Destroy(gameObject);
     }
 }
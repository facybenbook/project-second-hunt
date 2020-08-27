 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupHealth: MonoBehaviour {

	

	
     void OnTriggerEnter(Collider other) {
		 
		 
		
		
		
		
		GameObject go = GameObject.Find("healthtext");
		TextChange txtchange = go.GetComponent<TextChange>();
		if(txtchange.health < 80){
        txtchange.health = txtchange.health+20;
		}
		else {txtchange.health = txtchange.health + (99-txtchange.health);
		}
		
		
		
		
        Destroy(gameObject);

     }
 }
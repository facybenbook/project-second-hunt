 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupVolt: MonoBehaviour {

	

	
     void OnTriggerEnter(Collider other) {
		 
		GameObject go2 = GameObject.Find("polySurface11");
		GunGlow gunglow = go2.GetComponent<GunGlow>(); 
		
		gunglow.baseColor = Color.yellow;
		//gunglow.intensity = 3.0f;
		//gunglow.mat.SetColor = ("_EmissionColor", Color.red);
		
		
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
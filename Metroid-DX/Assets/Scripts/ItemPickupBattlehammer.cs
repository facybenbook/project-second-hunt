﻿ using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupBattlehammer: MonoBehaviour {

	

	
     void OnTriggerEnter(Collider other) {
		 
		GameObject go2 = GameObject.Find("polySurface11");
		GunGlow gunglow = go2.GetComponent<GunGlow>(); 
		gunglow.baseColor = Color.green;
		//gunglow.mat.SetColor = ("_EmissionColor", Color.red);
		
		
		 
		
		
		
        Destroy(gameObject);

     }
 }
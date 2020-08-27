 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupMagmaul: MonoBehaviour {

	

	
     void OnTriggerEnter(Collider other) {
		 
		GameObject go2 = GameObject.Find("polySurface11");
		GunGlow gunglow = go2.GetComponent<GunGlow>(); 
		Color orange = new Color(1.0f, 0.64f, 0.0f);
		gunglow.baseColor = orange;
		//gunglow.mat.SetColor = ("_EmissionColor", Color.red);
		
		

		
		
		
		
        Destroy(gameObject);

     }
 }
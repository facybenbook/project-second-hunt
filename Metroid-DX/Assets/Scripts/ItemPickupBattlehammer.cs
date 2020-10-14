 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI; // Required when Using UI elements.
 using System;


  
public class ItemPickupBattlehammer: MonoBehaviour {

 	public Sprite battle;
//	public Sprite imp;
//	public Sprite jud;
//	public Sprite mag;
//	public Sprite neutral;
//	public Sprite omega;
//	public Sprite shock;
//	public Sprite volt;

Image weaponsactive;	

	
     void OnTriggerEnter(Collider other) {
		 

		//gunglow.mat.SetColor = ("_EmissionColor", Color.red);
		
		

		
		
		
		
                IEnumerator Respawn()
    {
        //Print the time of when the function is first called.
        Debug.Log("Ammo picked up at: " + Time.time);
		
		Vector3 oldPosition = transform.position;
		
		transform.position = new Vector3(100, 100, 100);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(9);

		
        //After we have waited 5 seconds print the time again.
        Debug.Log("Ammo respawned at" + Time.time + " position: " + oldPosition);
		
		transform.position = oldPosition;

    }
		
		
		StartCoroutine(Respawn());
				//respawn item after pickup
		StartCoroutine(Respawn());
		///
		
		
		//gunglow//
		GameObject go2 = GameObject.Find("polySurface11");
		GunGlow gunglow = go2.GetComponent<GunGlow>(); 
		gunglow.baseColor = Color.green;
		//////
		
		
		
		///icon change on weapon pickup////
		GameObject go3 = GameObject.Find("weapon_active");
		weaponsactive = go3.GetComponent<Image>(); 
		weaponsactive.sprite = battle;
		/////
		
     }

     }
 
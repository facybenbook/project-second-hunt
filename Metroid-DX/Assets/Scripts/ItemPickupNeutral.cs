 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI; // Required when Using UI elements.
 using System;

  
public class ItemPickupNeutral: MonoBehaviour {
	
	AudioSource audioSource;
	public AudioClip impact;
	
	public Sprite battle;
	public Sprite imp;
	public Sprite jud;
	public Sprite mag;
	public Sprite neutral;
	public Sprite omega;
	public Sprite shock;
	public Sprite volt;
    public Sprite rocket;


private Sprite hunterweapon;

// if (hunter == samus) {hunterweapon = rocket;}
// if (hunter == sylux) {hunterweapon = shock;}
// if (hunter == kanden) {hunterweapon = volt;}
// if (hunter == noxus) {hunterweapon = jud;}
// if (hunter == trace) {hunterweapon = imp;}
// if (hunter == weavel) {hunterweapon = battle;}
// if (hunter == spire) {hunterweapon = mag;}


Image weaponsactive;	

	
     void OnTriggerEnter(Collider other) {
		 audioSource = GetComponent<AudioSource>();
		 audioSource.PlayOneShot(impact, 0.7F);
		 hunterweapon = shock;

		//gunglow.intensity = 3.0f;
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
		
	//respawn item after pickup
		StartCoroutine(Respawn());
		///
		
		if (GameObject.Find("polySurface11") != null)
{
    	//gunglow//
		GameObject go2 = GameObject.Find("polySurface11");
		GunGlow gunglow = go2.GetComponent<GunGlow>(); 
		gunglow.baseColor = Color.white;
		//////
}
		

				if (GameObject.Find("polySurface11") != null)
{
		///icon change on weapon pickup////
		GameObject go3 = GameObject.Find("weapon_active");
		weaponsactive = go3.GetComponent<Image>(); 
		weaponsactive.sprite = hunterweapon;
		/////
}
		

     }

     }
 
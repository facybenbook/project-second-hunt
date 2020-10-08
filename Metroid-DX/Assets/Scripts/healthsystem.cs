 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI; // Required when Using UI elements.
 using System;

  

public class healthsystem : MonoBehaviour {
	///////
	
	// AMMO SYSTEM IS LIVING HERE FOR NOW TOO ////
	
	
	
	
	
	
	
	
	
	
	///////
    Text health;
    Text ammo;
	float health_float;
	float ammo_float;
	Image hpbar;
	Image ammobar;
	//public GameObject healthtext;
	//// SYLUX ////
	public GameObject health_l;
	public GameObject ammo_r;
	public Sprite hpgreen;
	public Sprite hpred;
	//////
	
	
		//// SAMUS ////
	//public GameObject Bar;
	//public GameObject ammo_r;
	//public Sprite hpgreen;
	//public Sprite hpred;
	//////
	
	
 // Use this for initialization
     void Start () {
		


//health = Single.Parse(health);

		 
     }
     
     // Update is called once per frame
     void Update () {
		health = GameObject.Find("healthtext").GetComponent<Text>();
		
		////
		ammo = GameObject.Find("ammotext").GetComponent<Text>();
		////
		
		hpbar = health_l.GetComponent<Image> ();
		ammobar = ammo_r.GetComponent<Image> ();
		float.TryParse(health.text,out health_float);
		float.TryParse(ammo.text,out ammo_float);

		
		if(health_float > 25) {
		
			hpbar.sprite = hpgreen;
			health.color = Color.green;}
		
		else {
			// Color32(byte r, byte g, byte b, byte a);
			hpbar.sprite = hpred;
			health.color = new Color32( 209,70,97,255 );
		}
		 
		hpbar.fillAmount = (health_float/200);
		ammobar.fillAmount = (ammo_float/58);
		
		
		//ammo ist 29 fill = 0.5
		Debug.Log(health);
        //hpbar.fillAmount += 1.0f / 10f * Time.deltaTime;
	
	
	


		
		

		 
     }

 }
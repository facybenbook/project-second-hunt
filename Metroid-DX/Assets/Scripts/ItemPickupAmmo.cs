 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupAmmo: MonoBehaviour {

    
public int activeweapon;

//activeweapon = "test"	1
//activeweapon = "powerbeam" 2
//activeweapon = "voltdriver" 3
//activeweapon = "imp" 4
//activeweapon = "magmaul" 5
//activeweapon = "shockcoil" 6
//activeweapon = "battlehammer" 7
//activeweapon = "rocket" 8
//activeweapon = "judicator" 9
	
	
//test 119 10	
//Imperialist	29	5
//Magmaul	59	10
//Schock Coil	59	10
//Missile Launcher	59	N/A
//Volt Driver	119	20
//Judicator	119	20
//Battlehammer	149	25


     void OnTriggerEnter(Collider other) {
		activeweapon = 4;
		GameObject go = GameObject.Find("ammotext");
		TextChange_Ammo txtchange = go.GetComponent<TextChange_Ammo>();
		
		if (activeweapon == 7) {
		if(txtchange.health < 124){
        txtchange.health = txtchange.health+25;
		}
		else {txtchange.health = txtchange.health + (149-txtchange.health);
		}	
		}
		
		if (activeweapon == 4) {
		if(txtchange.health < 24){
        txtchange.health = txtchange.health+5;
		}
		else {txtchange.health = txtchange.health + (29-txtchange.health);
		}	
		}
        
		if (activeweapon == 1) {
		if(txtchange.health < 109){
        txtchange.health = txtchange.health+10;
		}
		else {txtchange.health = txtchange.health + (119-txtchange.health);
		}	
		}
        
		

        	
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
     }
 }
 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupHealth: MonoBehaviour {

	

	
     void OnTriggerEnter(Collider other) {
		 


		
		GameObject go = GameObject.Find("healthtext");
		TextChange txtchange = go.GetComponent<TextChange>();
		if(txtchange.health < 140){
        txtchange.health = txtchange.health+60;
		}
		else {txtchange.health = txtchange.health + (199-txtchange.health);
		}
		
		
		
		
        IEnumerator Respawn()
    {
        //Print the time of when the function is first called.
        Debug.Log("Small health orb picked up at: " + Time.time);
		
		Vector3 oldPosition = transform.position;
		
		transform.position = new Vector3(100, 100, 100);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(8);

		
        //After we have waited 5 seconds print the time again.
        Debug.Log("Small health orb respawned at" + Time.time + " position: " + oldPosition);
		
		transform.position = oldPosition;

    }
		
		
		StartCoroutine(Respawn());

     }
 }
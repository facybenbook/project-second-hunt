 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupRocket: MonoBehaviour {
	
	
     void OnTriggerEnter(Collider other) {
		GameObject go = GameObject.Find("rockettext");
		TextChange_Rocket txtchange = go.GetComponent<TextChange_Rocket>();
        txtchange.health++;
		
		
		

        	
        IEnumerator Respawn()
    {
        //Print the time of when the function is first called.
        Debug.Log("Rocket picked up at: " + Time.time);
		
		Vector3 oldPosition = transform.position;
		
		transform.position = new Vector3(100, 100, 100);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(9);

		
        //After we have waited 5 seconds print the time again.
        Debug.Log("Rocket respawned at" + Time.time + " position: " + oldPosition);
		
		transform.position = oldPosition;

    }
		
		
		StartCoroutine(Respawn());
     }
 }
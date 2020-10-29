 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupHealth_big: MonoBehaviour {

	AudioSource audioSource;
	
	public AudioClip impact;

	
     void OnTriggerEnter(Collider other) {
		 

		audioSource = GetComponent<AudioSource>();
		audioSource.PlayOneShot(impact, 0.7F);
		
		
		GameObject go = GameObject.Find("healthtext");
		TextChange txtchange = go.GetComponent<TextChange>();
		if(txtchange.health < 99){
        txtchange.health = txtchange.health+100;
		}
		else {txtchange.health = txtchange.health + (199-txtchange.health);
		}
		
		
		IEnumerator Respawn()
    {
        //Print the time of when the function is first called.
        Debug.Log("Big health orb picked up at: " + Time.time);
		
		Vector3 oldPosition = transform.position;
		
		transform.position = new Vector3(100, 100, 100);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);

		
        //After we have waited 5 seconds print the time again.
        Debug.Log("Big health orb respawned at" + Time.time + " position: " + oldPosition);
		
		transform.position = oldPosition;

    }
		
		
		StartCoroutine(Respawn());
		
		
		

     }
 }
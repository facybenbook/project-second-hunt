 using UnityEngine;
 using System.Collections;
 

  
public class ItemPickupJud: MonoBehaviour {

	

	
     void OnTriggerEnter(Collider other) {
		 
		GameObject go2 = GameObject.Find("polySurface11");
		GunGlow gunglow = go2.GetComponent<GunGlow>(); 
		
		gunglow.baseColor = Color.cyan;
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
		
		
		StartCoroutine(Respawn());
     }

     }
 
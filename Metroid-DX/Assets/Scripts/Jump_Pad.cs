 using UnityEngine;
 using System.Collections;
 

  
public class Jump_Pad: MonoBehaviour {

	public float force_pad;

	
     void OnTriggerEnter(Collider other) {
		 

//m_Jump_Pad = true for jumppad
		
		GameObject go = GameObject.Find("FPSController");
		UnityStandardAssets.Characters.FirstPerson.FirstPersonController  FirstPersonController  = go.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
		
		
		StartCoroutine(Jumppad());
		
		IEnumerator Jumppad()
    {
        
        Debug.Log("Jumppad used");
		FirstPersonController.Padforce = force_pad;
		
		
		
		FirstPersonController.m_Jump_Pad = true;
        yield return new WaitForSeconds(2);
		FirstPersonController.m_Jump_Pad = false;


		
  

    }
	 }
 }
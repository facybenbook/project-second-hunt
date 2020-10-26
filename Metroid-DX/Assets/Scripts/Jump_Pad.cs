 using UnityEngine;
 using System.Collections;
 

  
public class Jump_Pad: MonoBehaviour {

	public float force_pad;
	public int x;
	public int y;
	public int z;
	Rigidbody morph;
     void OnTriggerEnter(Collider other) {
		 

//m_Jump_Pad = true for jumppad
		
		GameObject go = GameObject.Find("FPSController");

        
		UnityStandardAssets.Characters.FirstPerson.FirstPersonController  FirstPersonController  = go.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
		
		
		StartCoroutine(Jumppad());
		
		IEnumerator Jumppad()
    {
        
        Debug.Log("Jumppad used");
		//FirstPersonController.Padforce = force_pad;
		
		if (GameObject.Find("Morphball") != null){
		GameObject go2 = GameObject.Find("Morphball");
		morph = go2.GetComponent<Rigidbody>();			
		morph.AddForce(x, y, z, ForceMode.Impulse);
		}
		
		
		//FirstPersonController.m_Jump_Pad = true;
        yield return new WaitForSeconds(1);
		//FirstPersonController.m_Jump_Pad = false;


		
  

    }
	 }
 }
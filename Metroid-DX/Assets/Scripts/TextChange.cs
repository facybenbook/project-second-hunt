 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 

 public class TextChange : MonoBehaviour {
 
    Text txt;
    public int health;
	
 // Use this for initialization
     void Start () {
		


         txt = gameObject.GetComponent<Text>(); 
		 health = 10;
         txt.text=health.ToString();
		 
     }
     
     // Update is called once per frame
     void Update () {
        
	//healt to bar
	
	


		
		
		
       txt.text=health.ToString();
	  // Debug.Log(health);
		 
     }

 }
 
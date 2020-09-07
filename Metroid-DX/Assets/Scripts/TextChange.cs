 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 

 public class TextChange : MonoBehaviour {
 
    Text txt;
    public int health;
	
 // Use this for initialization
     void Start () {
		


         txt = gameObject.GetComponent<Text>(); 
		 health = 42;
         txt.text=health.ToString();
		 
     }
     
     // Update is called once per frame
     void Update () {
        
       txt.text=health.ToString();
	   Debug.Log(health);
		 
     }

 }
 
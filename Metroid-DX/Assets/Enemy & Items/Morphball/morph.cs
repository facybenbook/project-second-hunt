using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
[RequireComponent (typeof(Rigidbody))]  
  
public class morph : MonoBehaviour {  

private bool applyForce_w = false;
private bool applyForce_s = false;
private bool applyForce_d = false;
private bool applyForce_a = false;

public int morphFORCE;


void FixedUpdate() {
	Physics.gravity = new Vector3(0, -100.0F, 0);
	   Cursor.visible = false;
   Cursor.lockState = CursorLockMode.Locked;
	 //GetComponent<Rigidbody>().centerOfMass =  com;
	 
	if (Input.GetKeyDown("w")) {
        applyForce_w = true;
    } else {
        applyForce_w = false;
    }
	if (Input.GetKeyDown("s")) {
        applyForce_s = true;
    } else {
        applyForce_s = false;
    }	
	if (Input.GetKeyDown("q")) {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero; 
    } 	

    if (applyForce_w) {
        GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * morphFORCE,ForceMode.Impulse);
    }
    if (applyForce_s) {
        GetComponent<Rigidbody>().AddForce(-Camera.main.transform.forward * morphFORCE,ForceMode.Impulse);
    }
    }	

}  
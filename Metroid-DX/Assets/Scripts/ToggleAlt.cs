using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAlt : MonoBehaviour
{
	private bool altstatus;
	
	public GameObject alt_form;
	public GameObject player;
	public GameObject PlayerModelSamus;	
	public GameObject ball;	
	
	public GameObject ControllerAlt;
	public GameObject ControllerEgo;
	
	public GameObject cam_ego;
	public GameObject cam_alt;
	
	private CharacterController cc_ego;
	Animator anim;
	Camera ballcam;
	Camera egocam;

    // Start is called before the first frame update
    void Start()
    {	ballcam = cam_alt.GetComponent<Camera> ();
		egocam = cam_ego.GetComponent<Camera> ();
	
	
	
	
        anim = PlayerModelSamus.GetComponent<Animator> ();
		anim.SetInteger("condition", 0);
		

		cc_ego = ControllerEgo.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {	



		
		Vector3 offset = new Vector3(0, 1, 0);
		Vector3 offset2 = new Vector3(0, 0.5f, 0);

		
		
		if (Input.GetKeyDown("q") && altstatus == false){altstatus = true;}
		else if (Input.GetKeyDown("q") && altstatus == true){altstatus = false;}
			
		
		//activate ego view
		if (Input.GetKeyDown("q") && altstatus == false)
        {	
			cc_ego.enabled = false;

			cc_ego.transform.position = ball.transform.position + offset;
			cc_ego.enabled = true;           

			player.SetActive(true);
			alt_form.SetActive(false);
			
	
        }
		////
		

		//activate alt form
		if (Input.GetKeyDown("q") && altstatus == true)
        {	
			
			ball.transform.position = cc_ego.transform.position - offset2;
			alt_form.SetActive(true);
			player.SetActive(false);
			
        }
		/////
 
 //var GameObject.GetComponent(scriptname).enabled = true; 
    }
}

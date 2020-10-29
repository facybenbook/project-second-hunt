using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ToggleAlt : MonoBehaviour
{
	private bool altstatus;
	AudioSource audioSource;
 
 public GameObject alt_form;
	public GameObject player;
	public GameObject PlayerModelSamus;	
	public GameObject ball;	
	public GameObject ball_parent;	
	
	public GameObject ControllerAlt;
	public GameObject ControllerEgo;
	
	public GameObject cam_ego;
	public GameObject cam_alt;
	
	///ALIGN CAM///
	////FirstPersonCharacterM / followcam owner
	public GameObject FPCM;
	////
	//public GameObject MSLOCK;
	//////
	private CharacterController cc_ego;

	public AudioClip MorphIn;
	public AudioClip MorphOut;
	Animator anim;
	Camera ballcam;
	Camera egocam;
	float y;
	float xlog = 0;
	float floatfp;
	FirstPersonController fpc; 
	
public float scale(float OldMin, float OldMax, float NewMin, float NewMax, float OldValue){
 
    float OldRange = (OldMax - OldMin);
    float NewRange = (NewMax - NewMin);
    float NewValue = (((OldValue - OldMin) * NewRange) / OldRange) + NewMin;
 
    return(NewValue);
}

    // Start is called before the first frame update
    void Start()
	
    {	ballcam = cam_alt.GetComponent<Camera> ();
		egocam = cam_ego.GetComponent<Camera> ();
		audioSource = GetComponent<AudioSource>();
		fpc = GameObject.FindObjectOfType<FirstPersonController>();


	
       // anim = PlayerModelSamus.GetComponent<Animator> ();
		//anim.SetInteger("condition", 0);
		

		cc_ego = ControllerEgo.GetComponent<CharacterController>();
		FPCM.GetComponent<followcam>().y = 0;
	
    }

    // Update is called once per frame
    void Update()
    {	



			
		Vector3 offset = new Vector3(0, 1, 0);
		Vector3 offset2 = new Vector3(0, 0.5f, 0);

		
		
		if (Input.GetKeyDown("q") && altstatus == false){altstatus = true;}
		else if (Input.GetKeyDown("q") && altstatus == true){altstatus = false;}
			
		if (altstatus == true){	
		
		///samus to morph orientation
		}

		//activate ego view
		if (Input.GetKeyDown("q") && altstatus == false)
        {	
			cc_ego.enabled = false;

			cc_ego.transform.position = ball.transform.position + offset;
			cc_ego.enabled = true;           

			player.SetActive(true);
			alt_form.SetActive(false);
			audioSource.PlayOneShot(MorphOut, 0.7F);
			//fpc.m_MouseLook.m_CharacterTargetRot = Quaternion.Euler (0f, 0f, 0f);
			//fpc.m_MouseLook.m_CameraTargetRot = Quaternion.Euler (0f, 0f, 0f);


			
	
        }
		////
		

		//activate alt form
 
		

		if (Input.GetKeyDown("q") && altstatus == true)
        {	

			
			ball.transform.position = cc_ego.transform.position - offset2;
			ball.transform.rotation = cc_ego.transform.rotation;
		
			
			alt_form.SetActive(true);
			player.SetActive(false);
			audioSource.PlayOneShot(MorphIn, 0.7F);


						
			
        }

		/////
		

		
		
		
float scaleMe = fpc.m_MouseLook.m_CameraTargetRot.eulerAngles.x;
float scaled = scale(90f, 280f, 80, -80, scaleMe);	
//Debug.Log(fpc.m_MouseLook.m_CharacterTargetRot.eulerAngles);	//left and right


//Debug.Log(FPCM.GetComponent<followcam>().x);	//left and right

//Debug.Log(fpc.m_MouseLook.m_CameraTargetRot.eulerAngles.x);
//Debug.Log(FPCM.GetComponent<followcam>().y);
//Debug.Log(scaled);
//Debug.Log(FPCM.transform.rotation.eulerAngles);
 


	//if (Input.GetKeyDown("r")){ball_parent.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);	}	
	if (Input.GetKeyDown("q")){		
	
	//left and right
			FPCM.GetComponent<followcam>().x = fpc.m_MouseLook.m_CharacterTargetRot.eulerAngles.y; ///samus to morph orientation
			floatfp = FPCM.transform.rotation.eulerAngles.y;
			fpc.m_MouseLook.m_CharacterTargetRot = Quaternion.Euler(0, floatfp, 0); //FPCM.GetComponent<followcam>().y; ///morph to samus orientation
			


 	//up and down		
			FPCM.GetComponent<followcam>().y = 0;
			
		
	}
	


	
 //Debug.Log(fpc.m_MouseLook.m_CharacterTargetRot.y);		//left and right movement
//Debug.Log(FPCM.GetComponent<followcam>().x);	//left and right movement



		/////
  }
}

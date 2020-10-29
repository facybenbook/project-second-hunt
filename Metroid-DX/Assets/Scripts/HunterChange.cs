using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterChange : MonoBehaviour
{	
	public GameObject samus;
	public GameObject sylux;
	public GameObject trace;
    // Start is called before the first frame update
    void Start()
    {

	
    }

    // Update is called once per frame
    void Update()
{
	
	
	
	
  	if (Input.GetKeyDown("1"))
			{	
			samus.SetActive(true);
			sylux.SetActive(false); 
			trace.SetActive(false); 
			}
			
  	if (Input.GetKeyDown("2"))
			{	
			samus.SetActive(false);
			sylux.SetActive(true);
			trace.SetActive(false);
			}			
			
  	if (Input.GetKeyDown("3"))
			{	
			samus.SetActive(false);
			sylux.SetActive(false);
			trace.SetActive(true);
			}			
			
			
			
}
			
}

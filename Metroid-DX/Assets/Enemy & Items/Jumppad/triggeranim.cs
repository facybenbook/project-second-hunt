using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeranim: MonoBehaviour
{
	private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
		
		StartCoroutine(AnimationPlay());
		
		IEnumerator AnimationPlay()
    {	gameObject.GetComponent<Animator>().Play("PadBeam");
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("anim");
    }
    }
}

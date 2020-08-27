using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunGlow : MonoBehaviour
 
{
	public Color baseColor;
	public float intensity;
    // Start is called before the first frame update
    void Start()
    {
    baseColor = Color.yellow;
    }

    // Update is called once per frame
 void Update () {
         Renderer renderer = GetComponent<Renderer> ();
         Material mat = renderer.material;
		 
		 float floor = 0.2f;
		 float ceiling = 3f;
		 float emission = floor + Mathf.PingPong (Time.time, ceiling - floor);
		 float intensity = 2.0f;

//mat.SetColor("_EmissionColor", new Color(0.0f,0.7f,1.0f,1.0f) * intensity);


         
         
         //Replace this with whatever you want for your base color at emission level '1'
 
         Color finalColor = baseColor * Mathf.LinearToGammaSpace (emission);
 
         mat.SetColor ("_EmissionColor", finalColor * intensity);
     }
}




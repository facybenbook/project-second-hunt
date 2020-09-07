using UnityEngine;
using System.Collections;
 
public class camera2d : MonoBehaviour
{
    public Camera m_Camera;
 
    //Orient the camera after all movement is completed this frame to avoid jittering
     private void LateUpdate()
     {
          transform.rotation = Camera.main.transform.rotation;
     }
}
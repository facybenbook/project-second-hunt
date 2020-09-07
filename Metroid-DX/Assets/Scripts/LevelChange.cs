using UnityEngine;
using System.Collections;
 
public class LevelChange: MonoBehaviour {
 
void Update(){
if(Input.GetKeyDown(KeyCode.Escape)){
Cursor.lockState = CursorLockMode.None;	
Cursor.visible = true;
Application.LoadLevel("MainMenu");

}

}
}
using UnityEngine;
using System.Collections;


//this class is used to handle right button pressed 
//by the user in the instructions screen 
public class RightScript : MonoBehaviour {

	void Update () {
		foreach(Touch touch in Input.touches){
			if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended){
				if (InstructionsScript.count < 3)
					InstructionsScript.count++;
			}
		}
	}
}

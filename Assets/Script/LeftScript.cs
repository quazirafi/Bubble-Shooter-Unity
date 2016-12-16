using UnityEngine;
using System.Collections;

//this class is used to handle the left button
//pressed by the user in the instructions screen
public class LeftScript : MonoBehaviour {
	
	void Update () {
		foreach(Touch touch in Input.touches){
			if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended){
				if (InstructionsScript.count>0)
					InstructionsScript.count--;
			}
		}
	}
}

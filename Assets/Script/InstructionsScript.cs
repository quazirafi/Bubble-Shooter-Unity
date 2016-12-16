using UnityEngine;
using System.Collections;

//this class manages the instructions screen

public class InstructionsScript : MonoBehaviour {

	private int buttonWidth = 200;
	private int buttonHeight = 50;
	public Texture backgroundTexture1;
	public Texture backgroundTexture2;
	public Texture backgroundTexture3;
	public Texture backgroundTexture4;
	public static int count=0;

	public GUISkin ohno;

	void Start(){
		count = 0;
	}

	//method to draw the button
	void OnGUI(){
		GUI.skin = ohno;
		if (count == 0){
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture1);
			if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2,380,buttonWidth,buttonHeight),"Back")){
				Application.LoadLevel(0);
			}
		}
		else if (count == 1)
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture2);
		else if (count ==2)
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture3);
		else if (count ==3)
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture4);


	}	
}

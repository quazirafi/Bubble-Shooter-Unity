using UnityEngine;
using System.Collections;

//this class handles the MainMenu Screen

public class MainMenuScript : MonoBehaviour {

	private int buttonWidth = 200;
	private int buttonHeight = 50;
	public Texture backgroundTexture;
	public GUISkin ohno;

	//method to draw the buttons
	void OnGUI () {
		GUI.skin = ohno;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,Screen.height/2-buttonHeight/2+85,buttonWidth,buttonHeight),"Play")){
			//previous
			//Application.LoadLevel(1);
			Application.LoadLevel(1);
		}
		else if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,Screen.height/2-buttonHeight/2+85+50,buttonWidth,buttonHeight),"Instructions")){
			Application.LoadLevel(8);
		}
		else if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,Screen.height/2-buttonHeight/2+85+100,buttonWidth,buttonHeight),"HighScores")){
			Application.LoadLevel(7);
		}
	}
}

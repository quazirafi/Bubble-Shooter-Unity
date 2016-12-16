using UnityEngine;
using System.Collections;
using System.IO;

//this class manages the Highscore Menu
public class HighScoreScript : MonoBehaviour {

	private int buttonWidth = 200;
	private int buttonHeight = 50;
	public Texture backgroundTexture;
	public GUISkin ohno;

	//method to draw the button
	void OnGUI(){
		GUI.skin = ohno;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);
		float f = PlayerPrefs.GetFloat("HighScore");
		GUI.Label(new Rect(Screen.width/2-200,210,600,150),"HighScore : "+f.ToString());
		if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,Screen.height/2-buttonHeight/2+160.0f,buttonWidth,buttonHeight),"Back")){
			Application.LoadLevel(0);
		}
	}	
}

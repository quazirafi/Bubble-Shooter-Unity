using UnityEngine;
using System.Collections;

//this class handles the pausemenu Screen 

public class PauseButtonScript : MonoBehaviour {

	private int buttonWidth = 200;
	private int buttonHeight = 50;
	public Texture backgroundTexture;
	public GUISkin ohno;
	void Update () {
		foreach(Touch touch in Input.touches){
			if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended){
				if (Time.timeScale == 1)
					Time.timeScale = 0;
			}
		}
	}

	//method to draw the buttons
	void OnGUI () {
		GUI.skin = ohno;
		if (Time.timeScale == 0){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);
			
			if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,50,buttonWidth,buttonHeight),"Back")){
				Time.timeScale = 1;
			}
			else if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,100,buttonWidth,buttonHeight),"Restart")){
				ShowStatus.isBubbleDivAllowed = 0;
				ShowStatus.score = 0.0f;
				ShowStatus.lives = 4;
				ShowStatus.bullets = 35;
				ShowStatus.level2 = true;
				ShowStatus.level6 = false;
				ShowStatus.showHighScoreMsgInterval = 0.0f;
				Time.timeScale = 1;

				Application.LoadLevel(1);

			}
			else if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,150,buttonWidth,buttonHeight),"MainMenu")){
				ShowStatus.isBubbleDivAllowed = 0;
				ShowStatus.score = 0.0f;
				ShowStatus.lives = 4;
				ShowStatus.bullets = 35;
				ShowStatus.level2 = true;
				ShowStatus.level6 = false;
				ShowStatus.showHighScoreMsgInterval = 0.0f;
				Time.timeScale = 1;
				Application.LoadLevel(0);
			}

		}

		
	}

}

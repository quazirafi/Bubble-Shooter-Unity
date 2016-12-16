using UnityEngine;
using System.Collections;

//this class manages the gameoverscreen 

public class GameOverScript : MonoBehaviour {

	private int buttonWidth = 200;
	private int buttonHeight = 50;
	public Texture backgroundTexture;
	public GUISkin ohno;

	//method to draw the buttons
	void OnGUI () {
		GUI.skin = ohno;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		GUI.Label(new Rect(Screen.width/2-100,50,600,buttonHeight),"Your Score : "+ShowStatus.score.ToString());
		//GUI.skin = null;
		if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,Screen.height/2-buttonHeight/2+140.0f,buttonWidth,buttonHeight),"MainMenu")){
			if (ShowStatus.score > PlayerPrefs.GetFloat("HighScore")){
				PlayerPrefs.SetFloat("HighScore",ShowStatus.score);
			}
			ShowStatus.isBubbleDivAllowed = 0;
			ShowStatus.score = 0.0f;
			ShowStatus.lives = 4;
			ShowStatus.bullets = 35;
			ShowStatus.level2 = true;
			ShowStatus.level6 = false;
			ShowStatus.showHighScoreMsgInterval = 0.0f;
			Application.LoadLevel(0);
		}
		else if (GUI.Button(new Rect (Screen.width/2-buttonWidth/2+250,Screen.height/2-buttonHeight/2+190.0f,buttonWidth,buttonHeight),"Restart")){
			if (ShowStatus.score > PlayerPrefs.GetFloat("HighScore")){
				PlayerPrefs.SetFloat("HighScore",ShowStatus.score);
			}
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

	}
}

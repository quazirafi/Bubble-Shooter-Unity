using UnityEngine;
using System.Collections;


//this class is used to show the current status of the player
public class ShowStatus : MonoBehaviour {

	// Use this for initialization
	public static float score = 0.0f;
	public static float score2 = 0.0f;
	public static float score3 = 0.0f;
	public static float score4 = 0.0f;
	public static float destroyPlayerInterval = 0.0f;
	public static bool destroyPlayer = false;
	public static int lives = 4;
	public static int bullets = 35;
	public static int setLivesBullets = 0;
	public static int isBubbleDivAllowed = 0;
	public static bool level2=true,level3=false,level4=false,level5=false,level6=false;
	public static bool highScoreMessage =false;
	public static bool showWhatAShotMsg= false;
	public static string whatAShotMsg="";
	public static float showWhatAShotMsgInterval = 0.0f;
	public static float showHighScoreMsgInterval = 0.0f;
	private bool showLevelMsg;
	private float levelMsgInterval = 0.0f;
	public static bool comboMsg = false;
	public static float comboMsgInterval = 0.0f;
	public static int bubbleHit = 0;
	public static bool specialBulletOn = false;
	public static float specialBulletInterval = 0.0f;
	public GUISkin ohno,ohno2;
	void Start () {

		destroyPlayerInterval = 0.0f;
		destroyPlayer = false;
		specialBulletOn = false;
		specialBulletInterval = 0.0f;
		score2 = 0.0f;
		score3 = 0.0f;
		score4 = 0.0f;
		bubbleHit = 0;
		//showHighScoreMsgInterval = 0.0f;
		comboMsg = false;
		showLevelMsg = true;
		levelMsgInterval = 0.0f;
		whatAShotMsg="";
		showWhatAShotMsg= false;
		showWhatAShotMsgInterval = 0.0f;
		comboMsgInterval = 0.0f;

	}
	
	// Update is called once per frame
	void Update () {

		if (score > 100.0f && level2 == true){
			lives = 5;
			bullets = 50;
			level2 = false;
			level3 = true;
			showLevelMsg = true;
			levelMsgInterval = 0.0f;
		}

		else if (score > 200.0f && level3 == true){
			lives = 5;
			bullets = 50;
			level3 = false;
			level4 = true;
			Application.LoadLevel(4);
		}

		else if (score > 300.0f && level4 == true){
			lives = 5;
			bullets = 50;
			level4 = false;
			level5 = true;
			Application.LoadLevel(5);
		}

		 else if (score > 400.0f && level5 == true){
			lives = 4;
			bullets = 15;
			level5 = false;
			level6 = true;
			Application.LoadLevel(6);
		}
		if (showLevelMsg == true){
			levelMsgInterval += Time.deltaTime;
		}
		if (showWhatAShotMsg == true){
			showWhatAShotMsgInterval += Time.deltaTime;
		}
		if (comboMsg == true)
			comboMsgInterval += Time.deltaTime;
		if (specialBulletOn == true && specialBulletInterval<6.5f)
			specialBulletInterval += Time.deltaTime;
		else if (specialBulletInterval>6.5f){
			specialBulletInterval = 0.0f;
			specialBulletOn = false;
		}
		if (destroyPlayer == true && destroyPlayerInterval<3.0f){
			destroyPlayerInterval += Time.deltaTime;
		}
		else if (destroyPlayerInterval>3.0f){
			destroyPlayer = false;
			destroyPlayerInterval = 0.0f;
		}
		if (score > PlayerPrefs.GetFloat("HighScore")){
			showHighScoreMsgInterval += Time.deltaTime;
		}
		else if (score < PlayerPrefs.GetFloat("HighScore")){
			showHighScoreMsgInterval = 0.0f;
		}

	}

	void OnGUI(){
		GUI.skin = ohno;
		if (Time.timeScale==1){
			GUI.Label(new Rect(740,0,100,30),"Score : "+score.ToString());
			GUI.Label(new Rect(740,35,100,30),"Lives : "+lives.ToString());
			GUI.Label(new Rect(740,70,100,30),"Bullets : "+bullets.ToString());
			//GUI.Label(new Rect(740,105,100,30),"Score2 : "+score2.ToString());
			GUI.skin = ohno2;
			if (levelMsgInterval>0.0f && levelMsgInterval<3.0f){
				if (level2==true)
					GUI.Label(new Rect(Screen.width/2-100,80,300,50),"Level1 Starts");
				else if (level3==true)
					GUI.Label(new Rect(Screen.width/2-100,80,300,50),"Level2 Starts");
				else if (level4==true)
					GUI.Label(new Rect(Screen.width/2-100,80,300,50),"Level3 Starts");
				else if (level5==true)
					GUI.Label(new Rect(Screen.width/2-100,80,300,50),"Level4 Starts");
				else if (level6==true)
					GUI.Label(new Rect(280,80,300,50),"Survival Mode!!!");
			}
			else if (levelMsgInterval > 3.0f)
				showLevelMsg=false;
			if (showHighScoreMsgInterval>0.0f && showHighScoreMsgInterval<4.0f){
				GUI.Label(new Rect(280,200,300,50),"New Highscore!!!");
			}
			
			else if (comboMsgInterval>0.0f && comboMsgInterval<3.0f && showLevelMsg == false){
				GUI.Label(new Rect(Screen.width/2-190,80,450,50),"3 BUBBLE COMBO +10");
			}
			else if (showWhatAShotMsgInterval>0.0f && showWhatAShotMsgInterval<0.5f && showLevelMsg==false){
				if (whatAShotMsg=="WHAT A SHOT!!! +10" || whatAShotMsg=="WRONG BUBBLE!!! -10")
					GUI.Label(new Rect(Screen.width/2-190,80,450,50),whatAShotMsg);
				else if (whatAShotMsg=="+8 Bullets!!!" || whatAShotMsg=="+3 Lives!!!")
					GUI.Label(new Rect(Screen.width/2-90,80,300,50),whatAShotMsg);
				else if (whatAShotMsg=="Special Bullets On!!!")
					GUI.Label(new Rect(Screen.width/2-150,80,450,50),whatAShotMsg);
				else
					GUI.Label(new Rect(Screen.width/2-45,80,300,50),whatAShotMsg);
			}
			else if (showWhatAShotMsgInterval>0.5f){
				showWhatAShotMsg=false;
				showWhatAShotMsgInterval=0.0f;
				whatAShotMsg="";
			}
			if (comboMsgInterval>3.0f){
				comboMsg = false;
				comboMsgInterval = 0.0f;
				bubbleHit = 0;
			}
		}
	
	}
}

using UnityEngine;
using System.Collections;


//this class is used to handle the bullet prefab of the second player
public class ReverseBulletScript : MonoBehaviour {

	// Use this for initialization
	public GameObject explosion,explosion2,explosion3,explosion4,explosion5;
	public GameObject divbubble1,divbubble2;
	public bool moveFlag=false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (moveFlag == false)
		transform.Translate(Vector3.left*0.23f,Space.World);
		//else
		//transform.Translate(Vector3.left*0.23f,Space.World);
		if (transform.position.x < -9.0f){
			Destroy(gameObject);
		}
	}

	//method to handle collusion between bullet and bubbles
	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag == "Brothers"){
			Instantiate(explosion,otherObject.transform.position,otherObject.transform.rotation);
			float x = Random.RandomRange(-5.0f,7.0f);
			float y = -4.75f;
			float z =0.0f;
			Vector3 newpos=new Vector3(x,y,z);
			//this if is new
			if (otherObject.transform.position.y>-1.284262f && otherObject.transform.position.x>7.2f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=10.0f;
					ShowStatus.score3+=10.0f;
					ShowStatus.score4+=10.0f;
				}
				ShowStatus.score+=10.0f;
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="WHAT A SHOT!!! +10";
			}
			//end
			else if (otherObject.transform.position.y>-1.284262f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=4.0f;
					ShowStatus.score3+=4.0f;
					ShowStatus.score4+=4.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+4";	
				ShowStatus.score+=4.0f;
			}
			
			else{
				ShowStatus.score+=1.0f;
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=1.0f;
					ShowStatus.score3+=1.0f;
					ShowStatus.score4+=1.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+1";	
			}
			
			if (ShowStatus.score > 100.0f)
				//BubbleDivScript.amIAllowed = 1;
				ShowStatus.isBubbleDivAllowed = 1;
			otherObject.transform.position = newpos;
			if (ShowStatus.specialBulletOn == false)
				Destroy(gameObject);
		}
		else if (otherObject.tag == "SmallBrothers"){
			Instantiate(explosion,otherObject.transform.position,otherObject.transform.rotation);
			float x = 100.0f;
			float y = 100.0f;
			float z =0.0f;
			Vector3 newpos=new Vector3(x,y,z);
			++ShowStatus.bubbleHit;
			if (ShowStatus.bubbleHit==2){
				//Debug.Log("INSIDE 222");
				ShowStatus.comboMsg = true;
			}
			else if (otherObject.transform.position.y>-1.284262f && otherObject.transform.position.x>7.2f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=10.0f;
					ShowStatus.score3+=10.0f;
					ShowStatus.score4+=10.0f;
				}
				ShowStatus.score+=10.0f;
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="WHAT A SHOT!!! +10";	
			}
			//end
			else if (otherObject.transform.position.y>-1.284262f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=10.0f;
					ShowStatus.score3+=10.0f;
					ShowStatus.score4+=10.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+10";	
				ShowStatus.score+=10.0f;
			}
			
			else{
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=1.0f;
					ShowStatus.score3+=1.0f;
					ShowStatus.score4+=1.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+1";	
				ShowStatus.score+=1.0f;
			}
			
			
			
			SmallBubbleScript sbs = (SmallBubbleScript)otherObject.gameObject.GetComponent("SmallBubbleScript");
			sbs.flag2 = 0;
			otherObject.transform.position = newpos;
			if (ShowStatus.specialBulletOn == false)
				Destroy(gameObject);
		}
		else if (otherObject.tag == "RedBrothers"){
			Instantiate(explosion2,otherObject.transform.position,otherObject.transform.rotation);
			float x = Random.RandomRange(-5.0f,7.0f);
			float y = -4.75f;
			float z =0.0f;
			Vector3 newpos=new Vector3(x,y,z);
			ShowStatus.score-=4.0f;
			ShowStatus.showWhatAShotMsg = true;
			ShowStatus.whatAShotMsg="WRONG BUBBLE!!! -10";	
			otherObject.transform.position = newpos;
			if (ShowStatus.specialBulletOn == false)
				Destroy(gameObject);
		}
		else if (otherObject.tag == "GreenBrothers"){
			Instantiate(explosion3,otherObject.transform.position,otherObject.transform.rotation);
			float x = Random.RandomRange(-5.0f,7.0f);
			float y = -4.75f;
			float z =0.0f;
			Vector3 newpos=new Vector3(x,y,z);
			
			if (otherObject.transform.position.y>-1.284262f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=10.0f;
					ShowStatus.score3+=10.0f;
					ShowStatus.score4+=10.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+10";	
				ShowStatus.score+=10.0f;
			}
			
			else{
				ShowStatus.score+=1.0f;
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+1";	
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=4.0f;
					ShowStatus.score3+=4.0f;
					ShowStatus.score4+=4.0f;
				}
			}
			
			otherObject.transform.position = newpos;
			if (ShowStatus.specialBulletOn == false)
				Destroy(gameObject);
		}
		else if (otherObject.tag == "LifeBulletBrothers" || otherObject.tag == "LifeBulletBrothers2" || otherObject.tag == "PowerBrothers"){
			//Instantiate(explosion,otherObject.transform.position,otherObject.transform.rotation);
			float x = 400.0f;
			float y = 400.0f;
			float z =0.0f;
			Vector3 newpos=new Vector3(x,y,z);
			if (otherObject.transform.position.y>-1.284262f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=4.0f;
					ShowStatus.score4+=4.0f;
					ShowStatus.score3+=4.0f;
				}
				
				ShowStatus.score+=4.0f;
			}
			
			else{
				ShowStatus.score+=1.0f;
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=1.0f;
					ShowStatus.score3+=1.0f;
					ShowStatus.score4+=1.0f;
				}
				
			}
			
			if (otherObject.tag == "LifeBulletBrothers"){
				Instantiate(explosion5,otherObject.transform.position,otherObject.transform.rotation);
				ShowStatus.bullets+=8;
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+8 Bullets!!!";	
			}
			else if (otherObject.tag == "LifeBulletBrothers2"){
				Instantiate(explosion4,otherObject.transform.position,otherObject.transform.rotation);
				ShowStatus.lives+=3;
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+3 Lives!!!";	
			}
			else if (otherObject.tag == "PowerBrothers"){
				Instantiate(explosion4,otherObject.transform.position,otherObject.transform.rotation);
				ShowStatus.specialBulletOn = true;
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="Special Bullets On!!!";	
			}
			
			otherObject.transform.position = newpos;
			if (ShowStatus.specialBulletOn == false)
				Destroy(gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;


//this class handles the characteristics of ordianary divideable bubbles
public class BubbleDivScript : MonoBehaviour {

	public float MaxSpeed;
	public float MinSpeed;
	public GameObject divbubble1,divbubble2;
	private float currentSpeed;
	public float x,y,z;
	public int flag = 0,flag2 = 0;
	public static int amIAllowed = 0;
	public int test=0;
	// Use this for initialization
	void Start () {
		flag2 = 0;
		x = 100.0f;
		y = 200.0f;
		z =0.0f;
		transform.position = new Vector3(x,y,z);
	}
	
	// Update is called once per frame
	void Update () {
		//if (amIAllowed == 1){
			if (ShowStatus.isBubbleDivAllowed == 1){
			if (flag2 == 0){
				flag2 = 1;
				setPositionAndSpeed();
			}
			float amtToMove = currentSpeed * Time.deltaTime;
			float amtToMove2 = (currentSpeed-1) * Time.deltaTime;
			if (transform.position.x > 8.90f){
				flag = 1;
			}
			else if (transform.position.x < -8.65f){
				flag = 0 ;
			}
			if (flag == 1){
				transform.Translate(Vector3.left*amtToMove2,Space.World);
			}
			else if (flag == 0){
				transform.Translate(Vector3.right*amtToMove2,Space.World);
			}
			if (transform.position.y >= 6.677f && ShowStatus.level6==false){
				if (ShowStatus.bullets>0)
				ShowStatus.score-=0.5f;
				setPositionAndSpeed();
			}
			else if (transform.position.y >= 6.677f && ShowStatus.level6==true){
				//if (ShowStatus.bullets>0)
					ShowStatus.score+=0.5f;
				ShowStatus.score2+=0.5f;
				ShowStatus.score3+=0.5f;
				ShowStatus.score4+=0.5f;
				setPositionAndSpeed();
			}

			else{
				transform.Translate(Vector3.up*amtToMove,Space.World);
			}
		}
	}

	//resetting bubbles position when hit the top of the screen
	public void setPositionAndSpeed(){
		currentSpeed = Random.RandomRange(MinSpeed,MaxSpeed);
		x = Random.RandomRange(-7.0f,7.0f);
		y = -4.75f;
		z =0.0f;
		transform.position = new Vector3(x,y,z);
	}


	//when this kind of bubble is hit by the bullet then collusion handler
	void OnTriggerEnter(Collider OtherObject){

		if (OtherObject.tag == "bullet"){
			if (ShowStatus.specialBulletOn == false)
			Destroy(OtherObject.gameObject);
			//this if is new
			/*
			if (transform.position.y>-1.284262f && transform.position.x>7.2f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=10.0f;
					ShowStatus.score3+=10.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="WHAT A SHOT!!! +10";	
				ShowStatus.score+=10.0f;
			}*/
			//end
			/*
			else if (transform.position.y>-1.284262f){
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=4.0f;
					ShowStatus.score3+=4.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+4";	
				ShowStatus.score+=4.0f;
			}
				
			else{
				if (ShowStatus.level6 == true){
					ShowStatus.score2+=1.0f;
					ShowStatus.score3+=1.0f;
				}
				ShowStatus.showWhatAShotMsg = true;
				ShowStatus.whatAShotMsg="+1";	
				ShowStatus.score+=1.0f;
			}*/
			Vector3 newposs = new Vector3(transform.position.x,transform.position.y,transform.position.z);
			divbubble1.transform.position = newposs;
			divbubble2.transform.position = newposs;
			SmallBubbleScript sbs1 = (SmallBubbleScript)divbubble1.gameObject.GetComponent("SmallBubbleScript");
			SmallBubbleScript sbs2 = (SmallBubbleScript)divbubble2.gameObject.GetComponent("SmallBubbleScript");
			sbs1.flag2=1;
			sbs2.flag2=1;
			//Destroy(this.gameObject);
			setPositionAndSpeed();
		}
	}
}

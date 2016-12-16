using UnityEngine;
using System.Collections;


//this class is used to handle the characteristics of the small bubbles
public class SmallBubbleScript : MonoBehaviour {

	public float MinSpeed;
	public float MaxSpeed;
	private float currentSpeed;
	public float x,y,z;
	public int flag = 0,flag2 = 0;
	public int test=0;

	//use this for initialization
	void Start(){
		currentSpeed = Random.RandomRange(MinSpeed,MaxSpeed);
		transform.position = new Vector3(100.0f,100.0f,0.0f);
	}


	//update is called once per frame
	void Update () {
		if (flag2==1){
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
			if (transform.position.y >= 6.677f && ShowStatus.level6 == false){
				ShowStatus.bubbleHit = 0;
				if (ShowStatus.bullets>0)
				ShowStatus.score-=0.5f;
				transform.position = new Vector3(100.0f,100.0f,0.0f);
				flag2 = 0;
			}
			else if (transform.position.y >= 6.677f && ShowStatus.level6 == true){
				ShowStatus.bubbleHit = 0;
				//if (ShowStatus.bullets>0)
					ShowStatus.score+=0.5f;
				ShowStatus.score2+=0.5f;
				ShowStatus.score3+=0.5f;
				ShowStatus.score4+=0.5f;
				transform.position = new Vector3(100.0f,100.0f,0.0f);
				flag2 = 0;
			}
			else{
				transform.Translate(Vector3.up*amtToMove,Space.World);
			}
		}

		
	}

	//ReSetting position & speed
	public void setPositionAndSpeed(){
		currentSpeed = Random.RandomRange(MinSpeed,MaxSpeed);
		x = Random.RandomRange(-7.0f,7.0f);
		y = -4.75f;
		z =0.0f;
		transform.position = new Vector3(x,y,z);

	}
}

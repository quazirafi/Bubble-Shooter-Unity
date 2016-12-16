using UnityEngine;
using System.Collections;

//this class handles the characteristics of ordianary bubbles

public class Bubble : MonoBehaviour {
	public float MinSpeed;
	public float MaxSpeed;
	private float currentSpeed;
	public float x,y,z;
	public int flag = 0;
	public int test=0;
	// Use this for initialization
	void Start () {
		//setPositionAndSpeed();
		currentSpeed = Random.RandomRange(MinSpeed,MaxSpeed);
		//this is it
		x = Random.RandomRange(-7.0f,7.0f);
		y = Random.RandomRange(-3.5f,5.5f);
		z =0.0f;
		transform.position = new Vector3(x,y,z);
	}
	
	// Update is called once per frame
	void Update () {
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

	//resetting bubbles position when hit the top of the screen
	public void setPositionAndSpeed(){
		currentSpeed = Random.RandomRange(MinSpeed,MaxSpeed);
		x = Random.RandomRange(-7.0f,7.0f);
		y = -4.75f;
		z =0.0f;
		transform.position = new Vector3(x,y,z);
	}
}

using UnityEngine;
using System.Collections;


//this class is used to handle the characteristics of the special bubbles
public class LifeBulletBubbleScript : MonoBehaviour {

	public float MinSpeed;
	public float MaxSpeed;
	private float currentSpeed;
	public float x,y,z;
	public int flag = 0;
	public int test=0;
	// Use this for initialization
	void Start () {
		//setPositionAndSpeed();
		currentSpeed = 0.0f;
		//this is it
		x = 400.0f;
		y = 400.0f;
		z =0.0f;
		transform.position = new Vector3(x,y,z);
	}
	
	// Update is called once per frame
	void Update () {
		if (ShowStatus.score2 > 20.0f){
			setPositionAndSpeed();
			ShowStatus.score2 = 0.0f;
		}
		else if (ShowStatus.score3 > 20.0f){
			setPositionAndSpeed();
			ShowStatus.score3 = 0.0f;
		} 
		else if (ShowStatus.score4 > 20.0f){
			setPositionAndSpeed();
			ShowStatus.score4 = 0.0f;
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
		if (transform.position.y >= 6.677f){
			//ShowStatus.score-=0.5f;
			setToZero();
		}
		else{
			transform.Translate(Vector3.up*amtToMove,Space.World);
		}
		
	}

	//resetting position & speed
	public void setPositionAndSpeed(){
		currentSpeed = Random.RandomRange(MinSpeed,MaxSpeed);
		x = Random.RandomRange(-7.0f,7.0f);
		y = -4.75f;
		z =0.0f;
		transform.position = new Vector3(x,y,z);
	}

	//resetting the position & velocity to zero 
	//when the special bubble hits the top of the screen
	public void setToZero(){
		currentSpeed = 0.0f;
		x = 400.0f;
		y = 400.0f;
		z =0.0f;
		transform.position = new Vector3(x,y,z);
	}
}

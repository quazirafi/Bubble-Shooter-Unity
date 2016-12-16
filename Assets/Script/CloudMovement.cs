using UnityEngine;
using System.Collections;

//this class is used to handle the characteristics of the cloud
public class CloudMovement : MonoBehaviour {

	public float MinSpeed;
	public float MaxSpeed;
	private float currentSpeed;
	public float x,y,z;

	// Use this for initialization
	void Start () {
		currentSpeed = Random.RandomRange(MinSpeed,MaxSpeed);
		x = Random.RandomRange(-7.0f,7.0f);
		y = Random.RandomRange(-1.5f,5.5f);
		//z =0.0f;
		z = Random.RandomRange(-1.0f,1.0f);
		transform.position = new Vector3(x,y,z);
	}
	
	// Update is called once per frame
	void Update () {
		float amtToMove = currentSpeed * Time.deltaTime;
		if (transform.position.x > 12.90f){
			x = -15.0f;
			y = Random.Range(-1.5f,5.5f);
			z = Random.Range(-1.0f,1.0f);
			//Vector3 newpos = new Vector3(x,y,transform.position.z);
			Vector3 newpos = new Vector3(x,y,z);
			transform.position = newpos;
		}
		else{
			transform.Translate(Vector3.right*amtToMove,Space.World);
		}
	}
}

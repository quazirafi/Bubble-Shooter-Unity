using UnityEngine;
using System.Collections;

//this class handles the characteristics of the player
public class Player : MonoBehaviour {

	// Use this for initialization

	void Start () {
		//transform.position = new Vector3(Screen.width/2,transform.position.y,transform.position.z);
	}
	
	public GameObject BulletPrefab;
	public GameObject explosion2;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && ShowStatus.bullets>=0 && Time.timeScale == 1){

			Vector3 pos = new Vector3(transform.position.x+0.5f,transform.position.y+0.5f,transform.position.z);
			if (ShowStatus.destroyPlayer == false)
			Instantiate(BulletPrefab,pos,Quaternion.identity);
			ShowStatus.bullets--;
			if (ShowStatus.bullets == -1)
				Application.LoadLevel(2);
		}
		if (Input.GetKey("up")){
			transform.Translate(Vector2.up*4*Time.deltaTime);
			if (transform.position.y > 6.677f){
				transform.position = new Vector3(transform.position.x,-4.75f,transform.position.z);
			}
		}
		if (Input.GetKey("down")){
			transform.Translate(-Vector2.up*4*Time.deltaTime);
			if (transform.position.y < -4.75f){
				transform.position = new Vector3(transform.position.x,6.5f,transform.position.z);
			}
		}
		if (Input.GetKey("escape")){
			if (Time.timeScale == 1)
				Time.timeScale = 0;
			else 
				Time.timeScale = 1;
		}
	
	}

	//method to handle the collusion between player and bubbles
	void OnTriggerEnter(Collider otherObject){
		if ((otherObject.tag != "bullet" && otherObject.tag != "LifeBulletBrothers" &&
		    otherObject.tag != "LifeBulletBrothers2" &&
		    otherObject.tag != "PowerBrothers")
		    && (ShowStatus.destroyPlayer == false)){
			ShowStatus.destroyPlayer = true;
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}
		/*if (otherObject.tag == "Brothers"){
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}
		else if (otherObject.tag == "PowerBrothers"){
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}
		else if (otherObject.tag == "DivBrothers"){
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}
		else if (otherObject.tag == "SmallBrothers"){
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}
		else if (otherObject.tag == "RedBrothers"){
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}
		else if (otherObject.tag == "GreenBrothers"){
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}
		else if (otherObject.tag == "LifeBulletBrothers" || otherObject.tag == "LifeBulletBrothers2"){
			StartCoroutine(DestroyPlayer());
			if (ShowStatus.lives>0)
				--ShowStatus.lives;
			if (ShowStatus.lives==0)
				Application.LoadLevel(2);
		}*/

	}

	//waiting for some time to get back after explosion
	IEnumerator DestroyPlayer(){
		Instantiate(explosion2,gameObject.transform.position,gameObject.transform.rotation);
		gameObject.renderer.enabled = false;
		transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		yield return new WaitForSeconds(1.5f);
		gameObject.renderer.enabled = true;
	}
}

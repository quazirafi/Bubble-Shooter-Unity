using UnityEngine;
using System.Collections;

//this class is used to handle the down button pressed by the user
public class Down : MonoBehaviour {


	void Start () {
	
	}
	public GameObject Player;
	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches){
			if (guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended){
				Player.transform.Translate(-Vector2.up*4*Time.deltaTime);
				if (Player.transform.position.y < -4.5f){
					Player.transform.position = new Vector3(Player.transform.position.x,6.1f,Player.transform.position.z);
				}
			}
		}
	}
}

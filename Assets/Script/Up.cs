using UnityEngine;
using System.Collections;


//this class is used to handle the up button pressed by the 
//user int he game
public class Up : MonoBehaviour {

	// Use this for initialization
	public GameObject Player;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches){
			if (guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended){
				Player.transform.Translate(Vector2.up*4*Time.deltaTime);
				if (Player.transform.position.y > 6.5f){
					Player.transform.position = new Vector3(Player.transform.position.x,-4.25f,Player.transform.position.z);
				}
			}
		}
	}
}

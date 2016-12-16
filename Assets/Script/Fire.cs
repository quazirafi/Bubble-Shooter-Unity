using UnityEngine;
using System.Collections;

//this class is used to handle the fire button pressed by user
public class Fire : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	public GameObject Player;
	public GameObject BulletPrefab;

	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches){
			if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended){

				Vector3 pos = new Vector3(Player.transform.position.x+0.5f,Player.transform.position.y+0.5f,Player.transform.position.z);
				if (ShowStatus.bullets >= 0 && Time.timeScale == 1 && ShowStatus.destroyPlayer == false){
					Bullet blt1,blt2;
					Instantiate(BulletPrefab,pos,Quaternion.identity);
					blt1 = (Bullet)BulletPrefab.gameObject.GetComponent("Bullet");
					ShowStatus.bullets--;
					if (ShowStatus.bullets == -1){
						Application.LoadLevel(2);
					}
				}
			}
		}
	}
}

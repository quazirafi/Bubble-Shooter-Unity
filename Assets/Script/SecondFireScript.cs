using UnityEngine;
using System.Collections;


//this class is used to handle the fire button pressed by 
//the user in the survival mode
public class SecondFireScript : MonoBehaviour {

	void Start () {
		
	}
	public GameObject Player;
	public GameObject Player2;
	public GameObject BulletPrefab;
	public GameObject BulletPrefab2;
	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches){
			if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended){
				Vector3 pos = new Vector3(Player.transform.position.x+0.5f,Player.transform.position.y+0.5f,Player.transform.position.z);
				if (ShowStatus.bullets >= 0 && Time.timeScale == 1 && ShowStatus.destroyPlayer == false){
					Instantiate(BulletPrefab,pos,Quaternion.identity);
					Vector3 pos2 = new Vector3(Player2.transform.position.x-0.5f,Player2.transform.position.y+0.5f,Player.transform.position.z);
					Instantiate(BulletPrefab2,pos2,Quaternion.identity);
					ShowStatus.bullets--;
					if (ShowStatus.bullets == -1){
						Application.LoadLevel(2);
					}
				}
			}
		}
	}
}

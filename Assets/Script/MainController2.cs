using UnityEngine;
using System.Collections;

//this class is used to handle the collusion between 
//special bubbles & all other bubbles

public class MainController2 : MonoBehaviour {

	public GameObject []bubbles;
	public GameObject []smallbubbles;
	public GameObject []divbubbles;
	public GameObject []finalbubbles;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//from here
		if (ShowStatus.level6 == true){
			for(int i=0;i<bubbles.Length;i++){
				for(int j=0;j<finalbubbles.Length;j++){
					if(bubbles[i]!=null && finalbubbles[j]!=null){
						float x=bubbles[i].transform.position.x-finalbubbles[j].transform.position.x;
						float y=bubbles[i].transform.position.y-finalbubbles[j].transform.position.y;
						float dist=Mathf.Sqrt(x*x+y*y);
						if (dist < 0.9f){
							Bubble OtherBubble;
							LifeBulletBubbleScript OtherBubble2;
							OtherBubble = (Bubble)bubbles[i].gameObject.GetComponent("Bubble");
							OtherBubble2 = (LifeBulletBubbleScript)finalbubbles[j].gameObject.GetComponent("LifeBulletBubbleScript");
							if (OtherBubble.flag==0)
								OtherBubble.flag=1;
							else if(OtherBubble.flag ==1)
								OtherBubble.flag=0;
							if (OtherBubble2.flag == 0)
								OtherBubble2.flag=1;
							else if (OtherBubble2.flag == 1)
								OtherBubble2.flag = 0;
							//if (OtherBubble.flag == 0)
							OtherBubble.transform.position = new Vector3(OtherBubble.transform.position.x+0.5f,OtherBubble.transform.position.y,OtherBubble.transform.position.z);
							//else 
							OtherBubble2.transform.position = new Vector3(OtherBubble2.transform.position.x-0.5f,OtherBubble2.transform.position.y,OtherBubble2.transform.position.z);
						}
					}
				}
			}
			
			for(int i=0;i<smallbubbles.Length;i++){
				for(int j=0;j<finalbubbles.Length;j++){
					if(smallbubbles[i]!=null && finalbubbles[j]!=null){
						float x=smallbubbles[i].transform.position.x-finalbubbles[j].transform.position.x;
						float y=smallbubbles[i].transform.position.y-finalbubbles[j].transform.position.y;
						float dist=Mathf.Sqrt(x*x+y*y);
						if (dist < 0.9f){
							SmallBubbleScript OtherBubble;
							LifeBulletBubbleScript OtherBubble2;
							OtherBubble = (SmallBubbleScript)smallbubbles[i].gameObject.GetComponent("SmallBubbleScript");
							OtherBubble2 = (LifeBulletBubbleScript)finalbubbles[j].gameObject.GetComponent("LifeBulletBubbleScript");
							if (OtherBubble.flag==0)
								OtherBubble.flag=1;
							else if(OtherBubble.flag ==1)
								OtherBubble.flag=0;
							if (OtherBubble2.flag == 0)
								OtherBubble2.flag=1;
							else if (OtherBubble2.flag == 1)
								OtherBubble2.flag = 0;
							//if (OtherBubble.flag == 0)
							OtherBubble.transform.position = new Vector3(OtherBubble.transform.position.x+0.5f,OtherBubble.transform.position.y,OtherBubble.transform.position.z);
							//else 
							OtherBubble2.transform.position = new Vector3(OtherBubble2.transform.position.x-0.5f,OtherBubble2.transform.position.y,OtherBubble2.transform.position.z);
						}
					}
				}
			}
			
			for(int i=0;i<divbubbles.Length;i++){
				for(int j=0;j<finalbubbles.Length;j++){
					if(divbubbles[i]!=null && finalbubbles[j]!=null){
						float x=divbubbles[i].transform.position.x-finalbubbles[j].transform.position.x;
						float y=divbubbles[i].transform.position.y-finalbubbles[j].transform.position.y;
						float dist=Mathf.Sqrt(x*x+y*y);
						if (dist < 0.9f){
							BubbleDivScript OtherBubble;
							LifeBulletBubbleScript OtherBubble2;
							OtherBubble = (BubbleDivScript)divbubbles[i].gameObject.GetComponent("BubbleDivScript");
							OtherBubble2 = (LifeBulletBubbleScript)finalbubbles[j].gameObject.GetComponent("LifeBulletBubbleScript");
							if (OtherBubble.flag==0)
								OtherBubble.flag=1;
							else if(OtherBubble.flag ==1)
								OtherBubble.flag=0;
							if (OtherBubble2.flag == 0)
								OtherBubble2.flag=1;
							else if (OtherBubble2.flag == 1)
								OtherBubble2.flag = 0;
							//if (OtherBubble.flag == 0)
							OtherBubble.transform.position = new Vector3(OtherBubble.transform.position.x+0.5f,OtherBubble.transform.position.y,OtherBubble.transform.position.z);
							//else 
							OtherBubble2.transform.position = new Vector3(OtherBubble2.transform.position.x-0.5f,OtherBubble2.transform.position.y,OtherBubble2.transform.position.z);
						}
					}
				}
			}
			
			for(int i=0;i<finalbubbles.Length;i++){
				for(int j=i+1;j<finalbubbles.Length;j++){
					if(i!=j && finalbubbles[i]!=null && finalbubbles[j]!=null){
						float x=finalbubbles[i].transform.position.x-finalbubbles[j].transform.position.x;
						float y=finalbubbles[i].transform.position.y-finalbubbles[j].transform.position.y;
						float dist=Mathf.Sqrt(x*x+y*y);
						if (dist < 1.0f){
							LifeBulletBubbleScript OtherBubble,OtherBubble2;
							OtherBubble = (LifeBulletBubbleScript)finalbubbles[i].gameObject.GetComponent("LifeBulletBubbleScript");
							OtherBubble2 = (LifeBulletBubbleScript)finalbubbles[j].gameObject.GetComponent("LifeBulletBubbleScript");
							if (OtherBubble.flag==0)
								OtherBubble.flag=1;
							else if(OtherBubble.flag ==1)
								OtherBubble.flag=0;
							if (OtherBubble2.flag == 0)
								OtherBubble2.flag=1;
							else if (OtherBubble2.flag == 1)
								OtherBubble2.flag = 0;
							OtherBubble.transform.position = new Vector3(OtherBubble.transform.position.x+0.5f,OtherBubble.transform.position.y,OtherBubble.transform.position.z);
							OtherBubble2.transform.position = new Vector3(OtherBubble2.transform.position.x-0.5f,OtherBubble2.transform.position.y,OtherBubble2.transform.position.z);
						}
					}
				}
			}
		}
		
		
	}
}

using UnityEngine;
using System.Collections;

//this class is used to handle the collusion between Normal bubbles
//Divideable Bubbles and Small Bubbles

public class MainController : MonoBehaviour {


	public GameObject []bubbles;
	public GameObject []smallbubbles;
	public GameObject []divbubbles;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0;i<bubbles.Length;i++){
			for(int j=i+1;j<bubbles.Length;j++){
				if(i!=j && bubbles[i]!=null && bubbles[j]!=null){
					float x=bubbles[i].transform.position.x-bubbles[j].transform.position.x;
					float y=bubbles[i].transform.position.y-bubbles[j].transform.position.y;
					float dist=Mathf.Sqrt(x*x+y*y);
					if (dist < 1.0f){
						Bubble OtherBubble,OtherBubble2;
							OtherBubble = (Bubble)bubbles[i].gameObject.GetComponent("Bubble");
							OtherBubble2 = (Bubble)bubbles[j].gameObject.GetComponent("Bubble");
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

		for(int i=0;i<smallbubbles.Length;i++){
			for(int j=i+1;j<smallbubbles.Length;j++){
				if(i!=j && smallbubbles[i]!=null && smallbubbles[j]!=null){
					float x=smallbubbles[i].transform.position.x-smallbubbles[j].transform.position.x;
					float y=smallbubbles[i].transform.position.y-smallbubbles[j].transform.position.y;
					float dist=Mathf.Sqrt(x*x+y*y);
					if (dist < 0.7f){
						SmallBubbleScript OtherBubble,OtherBubble2;
						OtherBubble = (SmallBubbleScript)smallbubbles[i].gameObject.GetComponent("SmallBubbleScript");
						OtherBubble2 = (SmallBubbleScript)smallbubbles[j].gameObject.GetComponent("SmallBubbleScript");
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

		for(int i=0;i<bubbles.Length;i++){
			for(int j=0;j<smallbubbles.Length;j++){
				if(bubbles[i]!=null && smallbubbles[j]!=null){
					float x=bubbles[i].transform.position.x-smallbubbles[j].transform.position.x;
					float y=bubbles[i].transform.position.y-smallbubbles[j].transform.position.y;
					float dist=Mathf.Sqrt(x*x+y*y);
					if (dist < 0.9f){
						Bubble OtherBubble;
						SmallBubbleScript OtherBubble2;
						OtherBubble = (Bubble)bubbles[i].gameObject.GetComponent("Bubble");
						OtherBubble2 = (SmallBubbleScript)smallbubbles[j].gameObject.GetComponent("SmallBubbleScript");
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
			for(int j=i+1;j<divbubbles.Length;j++){
				if(i!=j && divbubbles[i]!=null && divbubbles[j]!=null){
					float x=divbubbles[i].transform.position.x-divbubbles[j].transform.position.x;
					float y=divbubbles[i].transform.position.y-divbubbles[j].transform.position.y;
					float dist=Mathf.Sqrt(x*x+y*y);
					if (dist < 1.0f){
						BubbleDivScript OtherBubble,OtherBubble2;
						OtherBubble = (BubbleDivScript)divbubbles[i].gameObject.GetComponent("BubbleDivScript");
						OtherBubble2 = (BubbleDivScript)divbubbles[j].gameObject.GetComponent("BubbleDivScript");
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

		for(int i=0;i<divbubbles.Length;i++){
			for(int j=0;j<smallbubbles.Length;j++){
				if(divbubbles[i]!=null && smallbubbles[j]!=null){
					float x=divbubbles[i].transform.position.x-smallbubbles[j].transform.position.x;
					float y=divbubbles[i].transform.position.y-smallbubbles[j].transform.position.y;
					float dist=Mathf.Sqrt(x*x+y*y);
					if (dist < 0.9f){
						BubbleDivScript OtherBubble;
						SmallBubbleScript OtherBubble2;
						OtherBubble = (BubbleDivScript)divbubbles[i].gameObject.GetComponent("BubbleDivScript");
						OtherBubble2 = (SmallBubbleScript)smallbubbles[j].gameObject.GetComponent("SmallBubbleScript");
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
			for(int j=0;j<bubbles.Length;j++){
				if(divbubbles[i]!=null && bubbles[j]!=null){
					float x=divbubbles[i].transform.position.x-bubbles[j].transform.position.x;
					float y=divbubbles[i].transform.position.y-bubbles[j].transform.position.y;
					float dist=Mathf.Sqrt(x*x+y*y);
					if (dist < 1.0f){
						BubbleDivScript OtherBubble;
						Bubble OtherBubble2;
						OtherBubble = (BubbleDivScript)divbubbles[i].gameObject.GetComponent("BubbleDivScript");
						OtherBubble2 = (Bubble)bubbles[j].gameObject.GetComponent("Bubble");
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
	}
}

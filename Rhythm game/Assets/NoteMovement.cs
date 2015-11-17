using UnityEngine;
using System.Collections;

public class NoteMovement : MonoBehaviour {

	public float XSpeed;
	public float YSpeed;

	public float goalLX;
	public float goalRX;
	public float goalUY;
	public float goalDY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += new Vector3(XSpeed,YSpeed,0);
	}

	public float InGoal(){

		//TODO PITÄÄ OTTAA HUOMIOON TOISETKIN NOTET!!! Y:t ja X:t!
		if ((transform.position.x > goalLX) && (transform.position.x < goalRX)){
			
			//print("1 key was pressed at the right time! x: "+transform.position.x);
			return 32 - (Mathf.Abs(transform.position.x+32));
		}
		else if ((transform.position.y > goalDY) && (transform.position.y < goalUY)){
			
			//print("1 key was pressed at the right time! x: "+transform.position.x);
			return 32 - (Mathf.Abs(transform.position.x+32));
		}
		else{
			return 0;
		}
	}
}

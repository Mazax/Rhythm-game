using UnityEngine;
using System.Collections;

public class Note1Controller : MonoBehaviour {

	public float Speed;

	float goalLX = -64;
	float goalRX = 0;
	float goalUY = 0;
	float goalDY = -64;

	// Update is called once per frame
	void FixedUpdate () {
		transform.position += new Vector3(Speed,0,0);
	}

	public float InGoal(){
		//Look if note is in goal and if is give a score and destroy gameObject
		if ((transform.position.x > goalLX) && (transform.position.x < goalRX)){
			if ((transform.position.y > goalDY) && (transform.position.y < goalUY)){
				//give points basted on coordinates
				float result = 32 - (Mathf.Abs(transform.position.x+32));
				if (result < 0){
					result = 0;
				}else{
					Destroy(gameObject);
				}
			return result;
			}else{
				return 0;
			}
		}else{
			return 0;
		}
	}
}

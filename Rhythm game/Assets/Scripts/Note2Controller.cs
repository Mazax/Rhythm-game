using UnityEngine;
using System.Collections;

public class Note2Controller : MonoBehaviour {

	public float Speed;
	
	float goalLX = -64;
	float goalRX = 0;
	float goalUY = 64;
	float goalDY = 0;
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += new Vector3(0,-Speed,0);
	}
	
	public float InGoal(){
		//Look if note is in goal and if is give a score and destroy gameObject
		if ((transform.position.x > goalLX) && (transform.position.x < goalRX)){
			if ((transform.position.y > goalDY) && (transform.position.y < goalUY)){
				//give points basted on coordinates
				float result = 32 - (Mathf.Abs(-transform.position.y+32));
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
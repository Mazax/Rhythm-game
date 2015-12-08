using UnityEngine;
using System.Collections;

public class Note4Controller : MonoBehaviour {

	public float Speed;
    SpawnController4 sc;

    float goalLX = 0;
	float goalRX = 64;
	float goalUY = 64;
	float goalDY = 0;
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += new Vector3(-Speed,0,0);
        GameObject s1 = GameObject.FindWithTag("spawner4");
        sc = s1.GetComponent<SpawnController4>();
    }
	
	public float InGoal(){
		//Look if note is in goal and if is give a score and destroy gameObject
		if ((transform.position.x > goalLX) && (transform.position.x < goalRX)){
			if ((transform.position.y > goalDY) && (transform.position.y < goalUY)){
				//give points basted on coordinates
				float result = 32 - (Mathf.Abs(-transform.position.x+32));
				if (result < 0){
					result = 0;
				}else{
					Destroy(gameObject);
                    sc.CreateNote();
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
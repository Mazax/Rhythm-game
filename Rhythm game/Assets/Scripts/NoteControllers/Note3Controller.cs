﻿using UnityEngine;
using System.Collections;

public class Note3Controller: MonoBehaviour {

	public float Speed;
   // SpawnController3 sc;

    float goalLX = 0;
	float goalRX = 64;
	float goalUY = 0;
	float goalDY = -64;
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += new Vector3(0,Speed,0);
        GameObject s1 = GameObject.FindWithTag("spawner3");
        //sc = s1.GetComponent<SpawnController3>();
    }
	
	public float InGoal(){
		//Look if note is in goal and if is give a score and destroy gameObject
		if ((transform.position.x > goalLX) && (transform.position.x < goalRX)){
			if ((transform.position.y > goalDY) && (transform.position.y < goalUY)){
				//give points basted on coordinates
				float result = 32 - (Mathf.Abs(transform.position.y+32));
				if (result < 0){
					result = 0;
				}else{
					Destroy(gameObject);
                   // sc.CreateNote();
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
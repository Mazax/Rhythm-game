using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	GameObject[] notes;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("1")) {
			notes = GameObject.FindGameObjectsWithTag("note1");

			for (int i = 0; i < notes.Length; i++){

				//TODO Tämä ei toimi
				if ((notes[i].transform.position.x > -64) || (notes[i].transform.position.x < 64)){

					print("1 key was pressed at the right time!");
				}
			}
		}
	}
}

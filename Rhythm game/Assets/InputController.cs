using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	GameObject[] notes;
	public float goalLX;
	public float goalRX;
	public float goalUY;
	public float goalDY;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("1")) {
			notes = GameObject.FindGameObjectsWithTag("note1");

			for (int i = 0; i < notes.Length; i++){

				print("note 1: "+notes[i].GetComponent<NoteMovement>().InGoal() );
			}
		}
		if (Input.GetKeyDown ("2")) {
			notes = GameObject.FindGameObjectsWithTag("note2");
			
			for (int i = 0; i < notes.Length; i++){
				
				print("note 2: "+notes[i].GetComponent<NoteMovement>().InGoal() );
			}
		}
		if (Input.GetKeyDown ("3")) {
			notes = GameObject.FindGameObjectsWithTag("note3");
			
			for (int i = 0; i < notes.Length; i++){
				
				print("note 3: "+notes[i].GetComponent<NoteMovement>().InGoal() );
			}
		}
		if (Input.GetKeyDown ("4")) {
			notes = GameObject.FindGameObjectsWithTag("note4");
			
			for (int i = 0; i < notes.Length; i++){
				
				print("note 4: "+notes[i].GetComponent<NoteMovement>().InGoal() );
			}
		}
	}
}
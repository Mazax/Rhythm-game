﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class InputController : MonoBehaviour {
	GameObject[] notes;
    public GameObject textObject;
	public float goalLX;
	public float goalRX;
	public float goalUY;
	public float goalDY;

    float playerPoints = 0;

	public AudioClip impact;
	AudioSource audIo;

	// Use this for initialization
	void Start () {
		audIo = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("1")) {
			notes = GameObject.FindGameObjectsWithTag("note1");

			for (int i = 0; i < notes.Length; i++){
				float points = notes[i].GetComponent<Note1Controller>().InGoal();
                playerPoints += points;
                if (points > 0){
					print("note 1: "+points );
                    PrintPoitns();
                }
			}
		}

		if (Input.GetKeyDown ("2")) {
			notes = GameObject.FindGameObjectsWithTag("note2");
			
			for (int i = 0; i < notes.Length; i++){
				float points = notes[i].GetComponent<Note2Controller>().InGoal();
                playerPoints += points;
                if (points > 0){
					print("note 2: "+points );
                    PrintPoitns();
                }
			}
		}

		if (Input.GetKeyDown ("3")) {
            GetComponent<AudioSource>().PlayOneShot(impact, 0.4f);

            notes = GameObject.FindGameObjectsWithTag("note3");
			
			for (int i = 0; i < notes.Length; i++){
				
				float points = notes[i].GetComponent<Note3Controller>().InGoal();
                playerPoints += points;
                if (points > 0){
					print("note 3: "+points );
                    PrintPoitns();
                }
			}
		}
		if (Input.GetKeyDown ("4")) {
            GetComponent<AudioSource>().PlayOneShot(impact, 0.4f);

            notes = GameObject.FindGameObjectsWithTag("note4");
			
			for (int i = 0; i < notes.Length; i++){

				float points = notes[i].GetComponent<Note4Controller>().InGoal();
                playerPoints += points;
                if (points > 0){
					print("note 4: "+points );
                    PrintPoitns();
                }
			}
		}
	}

    void PrintPoitns() {
        textObject.GetComponent<Text>().text = "Points: " + (int)playerPoints;
    }
}
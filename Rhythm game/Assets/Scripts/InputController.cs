using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class InputController : MonoBehaviour {

	GameObject[] notes;
    public GameObject textObject;
    public GameObject sparks;

    public Transform goal1;
    public Transform goal2;
    public Transform goal3;
    public Transform goal4;

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
                    Instantiate(sparks, goal1.position, goal1.rotation);
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
                    Instantiate(sparks, goal2.position, goal2.rotation);
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
                    Instantiate(sparks, goal3.position, goal3.rotation);
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
                    Instantiate(sparks, goal4.position, new Quaternion(goal4.rotation.eulerAngles.x, goal4.rotation.eulerAngles.y, goal4.rotation.eulerAngles.z, 0));
                    PrintPoitns();
                }
			}
		}
	}

    void PrintPoitns() {
        textObject.GetComponent<Text>().text = "Points: " + (int)playerPoints;
    }
}
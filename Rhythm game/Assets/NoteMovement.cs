using UnityEngine;
using System.Collections;

public class NoteMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += new Vector3(0.01f,-0.01f,0);
	}
}

using UnityEngine;
using System.Collections;

public class NoteMovement : MonoBehaviour {

	public float XSpeed;
	public float YSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += new Vector3(XSpeed,YSpeed,0);
	}
}

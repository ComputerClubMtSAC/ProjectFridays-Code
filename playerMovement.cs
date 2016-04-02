using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float movementModifier = 5f;
	Vector3 direction;
	CharacterController control;

	// Use this for initialization
	void Start () {

		control = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {

		direction = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		direction.Normalize ();
		control.Move (direction * movementModifier * Time.deltaTime);
	
	}
}

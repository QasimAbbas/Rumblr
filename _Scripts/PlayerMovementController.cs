using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

	public float moveSpeed, rotateSpeed;

	private static Animator anim;
	private static Rigidbody rb;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//Controls movement animation
		anim.SetFloat ("speed", Input.GetAxis ("Vertical"));

		//COntrols player movement and rotation
		rb.AddForce (Input.GetAxisRaw("Vertical") * transform.forward * moveSpeed);
		transform.RotateAround (transform.position, Vector3.up, Input.GetAxis ("Horizontal") * rotateSpeed);

	}
}

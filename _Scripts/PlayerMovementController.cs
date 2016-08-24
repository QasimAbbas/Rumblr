using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

	public float moveSpeed, rotateSpeed, jumpSpeed;

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

		//Controls attacking
		if (Input.GetMouseButton (0)) {
			anim.SetBool ("attack", true);
		} else {
			anim.SetBool ("attack", false);
		}

		//Controls player movement and rotation
		rb.AddForce (Input.GetAxisRaw("Vertical") * transform.forward * moveSpeed);
		transform.RotateAround (transform.position, Vector3.up, Input.GetAxis ("Horizontal") * rotateSpeed);

		//Controls jumping
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (Vector3.up * jumpSpeed, ForceMode.Impulse);
		}
	}
}

using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

	private static Animator anim;
	private static float speed;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		speed = Input.GetAxis ("Vertical");
		anim.SetFloat ("speed", speed);
	}
}

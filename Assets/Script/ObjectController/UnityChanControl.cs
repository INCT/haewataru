using UnityEngine;
using System.Collections;

public class UnityChanControl : MonoBehaviour {
	
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		animator.SetBool("isWalking", true);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject playerObject = GameObject.FindWithTag("Player");
		Vector3 playerPosition = playerObject.transform.position;
		playerPosition.y = transform.position.y;
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerPosition - transform.position), 0.07f);
		transform.position += transform.forward * 1.0f;


		//transform.Rotate (0,transform.rotation.y-   ,0);

		  /*if (Input.GetKey("right")) {
			transform.Rotate(0, 10, 0);
		}
		if (Input.GetKey ("left")) {
			transform.Rotate(0, -10, 0);
		}*/
	}
}
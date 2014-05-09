using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	public float x = 0.0f;
	public float y = 0.0f;
	public float z = 0.0f;


	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.RightArrow)) 
			y = 5.0f;

		if (Input.GetKey(KeyCode.LeftArrow)) 
			y = -5.0f;
	
		transform.Rotate(0, y, 0);

		if (Input.GetKey(KeyCode.UpArrow)) 
			x = -5.0f;
			

		if (Input.GetKey(KeyCode.DownArrow)) 
			x = 5.0f;

		transform.Rotate(x, 0, 0);

		x = 0;
		y = 0;
		z = 0;

		transform.Translate (0,0,0.07f);


	}
}

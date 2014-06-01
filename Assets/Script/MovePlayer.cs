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
			y = 2.0f;

		if (Input.GetKey(KeyCode.LeftArrow)) 
			y = -2.0f;

		if (Input.GetKey(KeyCode.UpArrow)) 
			x = -2.0f;
			
		if (Input.GetKey(KeyCode.DownArrow)) 
			x = 2.0f;

		if(GameObject.Find("PlayerModel")){
			transform.Rotate(0, y, 0);
			transform.Rotate(x, 0, 0);

			transform.Translate (0,0,4f);
			}
		//RotateAngle ();

		x = 0;
		y = 0;
		z = 0;
	}

	void RotateAngle(){
		Debug.Log (transform.rotation.z);
	}

	void StartGame() {
		enabled = true;
	}
}

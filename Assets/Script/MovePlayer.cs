using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	public float x = 0.0f;
	public float y = 0.0f;
	public float z = 0.0f;

	string touchInfo = "test";

	void OnGUI(){
		GUI.Label (new Rect (10, 10, 300, 300), touchInfo);
	}

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

		touchInfo = "Screen:"+Screen.width+"*"+Screen.height+"\n";

		for (int i=0;i<Input.touchCount; i++) {
			touchInfo += i + " : x=" + Input.GetTouch (i).position.x + " y=" + Input.GetTouch (i).position.y + "\n";
		} 

		if (Input.touchCount >= 2) {
			int w = Screen.width;
			int h = Screen.height;

			float x0 = Input.GetTouch(0).position.x-w/2;
			float x1 = Input.GetTouch(1).position.x-w/2;
			float y0 = Input.GetTouch(0).position.y-h/2;
			float y1 = Input.GetTouch(1).position.y-h/2;

			if(x0 > 0 != x1 > 0){
				if(y0 > 0 == y1 > 0){
					x = -2.0f * (y0+y1)/h;
				}
				if(x0<0){
					y = -2.0f * (y1-y0)/h;
				}else{
					y = -2.0f * (y0-y1)/h;
				}
			}

			touchInfo += x0+","+y0+" & "+x1+","+y1+"\n";

		}

		if(GameObject.Find("PlayerModel")){
			transform.Rotate(0, y, 0);
			transform.Rotate(x, 0, 0);

			transform.Translate (0,0,2.0f);
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

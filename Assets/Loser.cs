using UnityEngine;
using System.Collections;

public class Loser : MonoBehaviour {

	GameObject target;

	// Use this for initialization
	void Start () {
		gameObject.renderer.enabled = false;
		//target = GameObject.Find("Manta0");
	}


	// Update is called once per frame
	void Update () {
		if (!GameObject.Find ("PlayerModel") && !gameObject.renderer.enabled){
			gameObject.renderer.enabled = true;
	
			GameObject maincamera = GameObject.Find ("Main Camera");

			transform.Translate (maincamera.transform.localPosition.x, maincamera.transform.localPosition.y - 180, maincamera.transform.localPosition.z + 40);
		}

		/*
		transform.localPosition.x = target.transform.localPosition.x;
		transform.localPosition.y = target.transform.localPosition.y;
		transform.localPosition.z = target.transform.localPosition.z + 1;*/
	}
}

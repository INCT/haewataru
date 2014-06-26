using UnityEngine;
using System.Collections;

public class isDiving : MonoBehaviour {

	void Update () {
		Camera Mono = GameObject.Find ("Main Camera Dive").GetComponent<Camera>();
		Camera DivingR = GameObject.Find ("Main Camera Right").GetComponent<Camera> ();
		Camera DivingL = GameObject.Find ("Main Camera Left").GetComponent<Camera> ();

		/*
		if(GameObject.Find ("Main Camera Dive") )
			Debug.Log ("AAAAAAAAAAAAAAAAAA");
		if(GameObject.Find ("Main Camera Right") )
			Debug.Log ("NOOOOOOOOOOOOOOOOOO");
*/

		if (PlayerPrefs.GetString ("isDiving") == "OFF") {
			Mono.enabled = true;
			DivingR.enabled = false;
			DivingL.enabled = false;


			/*
						//if (GameObject.Find ("Main Camera Left"))
			Debug.Log("OFFOFFOFFOFFOFF");
			Destroy (GameObject.FindWithTag ("CameraDive"));
						//if (GameObject.Find ("Main Camera Right"))
			Destroy (GameObject.Find ("CameraDive"));*/
				}
		else if (PlayerPrefs.GetString ("isDiving") == "ON") {
			Mono.enabled = false;
			DivingR.enabled = true;
			DivingL.enabled = true;
			Debug.Log("NNNNNNNNNNNNN");
			Destroy (GameObject.Find ("CameraNoneDive"));
		}
	}
}
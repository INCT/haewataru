using UnityEngine;
using System.Collections;

public class isDiving : MonoBehaviour {

	void Update () {
		Camera Mono = GameObject.Find ("Main Camera Dive").GetComponent<Camera>();
		Camera DivingR = GameObject.Find ("Main Camera Right").GetComponent<Camera> ();
		Camera DivingL = GameObject.Find ("Main Camera Left").GetComponent<Camera> ();


		if (PlayerPrefs.GetString ("isDiving") == "OFF") {
			Mono.enabled = true;
			DivingR.enabled = false;
			DivingL.enabled = false;

			}
		else if (PlayerPrefs.GetString ("isDiving") == "ON") {
			Mono.enabled = false;
			DivingR.enabled = true;
			DivingL.enabled = true;
			Destroy (GameObject.Find ("CameraNoneDive"));
		}
	}
}
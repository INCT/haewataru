using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Application.LoadLevel("Main");
		}
	}

	void OnGUI () {
		Rect rect = new Rect(Screen.width / 4,Screen.height / 2, Screen.width/2, Screen.height / 4);
		bool isClicked = GUI.Button(rect, "GAME START!");
		if (isClicked) {
			Application.LoadLevel("Stage1");
		}
	}
}
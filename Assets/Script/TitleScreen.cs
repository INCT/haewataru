using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Application.LoadLevel("Main");
		}
	}

	void OnGUI () {
		int sw = Screen.width;
		int sh = Screen.height;
		Rect startButton = new Rect(Screen.width / 4,Screen.height / 2, Screen.width/2, Screen.height / 4);
		Rect howToButton = new Rect(Screen.width / 4,Screen.height / 2, Screen.width/2, Screen.height / 4);
		Rect scoreButton = new Rect(Screen.width / 4,Screen.height / 2, Screen.width/2, Screen.height / 4);
		Rect optionButton = new Rect(Screen.width / 4,Screen.height / 2, Screen.width/2, Screen.height / 4);
		if (GUI.Button(startButton, "はじめる")) {
			Application.LoadLevel("Stage1");
		}
		if (GUI.Button(howToButton,"遊び方")) {
			Application.LoadLevel("Tutorial");
		}
		if (GUI.Button(scoreButton,"記録")) {
			Application.LoadLevel("Record");
		}
		if (GUI.Button(optionButton,"設定")) {
			Application.LoadLevel("Option");
		}

	}
}
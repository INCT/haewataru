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
		Rect startButton = new Rect(sw / 4,sh / 2, sw / 2, sh / 8);
		Rect howToButton = new Rect(sw / 4.5f,sh / 1.5f, sw / 6, sh / 8);
		Rect scoreButton = new Rect(sw / 3,sh / 1.5f, sw / 6, sh / 8);
		Rect optionButton = new Rect(sw / 1.75f,sh / 1.5f, sw / 6, sh / 8);
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
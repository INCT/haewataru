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
		GUILayout.BeginArea(new Rect(sw/4,sh/2,sw/2,sh/2));
		if (GUILayout.Button("はじめる",GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Stage1");
		}
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("遊び方",GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Tutorial");
		}
		if (GUILayout.Button("記録",GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Record");
		}
		if (GUILayout.Button("設定",GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Option");
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
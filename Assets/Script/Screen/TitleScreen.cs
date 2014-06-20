using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	public Texture2D score_im; 

	public GameObject GameObjectPrefab;
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Application.LoadLevel("Main");
		}
		/*
		if (GameObject.FindWithTag("Recode Button")) {
			Application.LoadLevel("Recode");
		}*/

	}

	void OnGUI () {
		int sw = Screen.width;
		int sh = Screen.height;
		GUILayout.BeginArea(new Rect(sw/4,sh/2 + 150,sw/2,sh/2));
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("遊び方",GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Tutorial");
		}
		if (GUI.Button( new Rect(sh/6,sh/6,sh/4,sh/6),score_im)) {
			Application.LoadLevel("Record");
		}
		if (GUILayout.Button("設定",GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Option");
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
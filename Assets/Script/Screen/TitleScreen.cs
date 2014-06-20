using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	public Texture2D score_im;
	public Texture2D option_im;
	public Texture2D tutorial_im; 

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
		GUILayout.BeginArea(new Rect(0,sh/2 + 150,sw,sh/2));
		GUILayout.BeginHorizontal();
		if (GUI.Button( new Rect(sw/8*1,0,sw/4,sh/6), tutorial_im)) {
			Application.LoadLevel("Tutorial");
		}
		if (GUI.Button( new Rect(sw/8*3,0,sw/4,sh/6), score_im)) {
			Application.LoadLevel("Record");
		}
		if (GUI.Button( new Rect(sw/8*5,0,sw/4,sh/6), option_im)) {
			Application.LoadLevel("Option");
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
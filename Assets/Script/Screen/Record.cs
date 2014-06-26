using UnityEngine;
using System.Collections;

public class Record : MonoBehaviour {
	public GUISkin skin;
	public Texture2D back_im;
	int[] score = new int[5];

	void Awake() {
		for (int i = 0; i < 5;i++) {
			if (PlayerPrefs.HasKey("score"+i)) {
				score[i] = PlayerPrefs.GetInt("score"+i);
			}
		}
	}

	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;
		GUILayout.BeginArea(new Rect(sw/4,sh/2,sw/2,sh/2));
		for (int i = 0; i < score.Length; i++) {
			GUILayout.Label("SCORE: "+ score[i].ToString(), "score");
		}
		if (GUILayout.Button(back_im,GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Title");
		}
		GUILayout.EndArea();
	}
}

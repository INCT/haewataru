using UnityEngine;
using System.Collections;

public class Record : MonoBehaviour {
	public GUISkin skin;
	int score = 0;

	void Awake() {
		if (PlayerPrefs.HasKey("score")) {
			score = PlayerPrefs.GetInt("score");
		}
	}

	void OnGUI() {
		GUI.skin = skin;
		GUI.Label(new Rect(Screen.width / 2,Screen.height / 4, Screen.width / 4,Screen.height / 4),"SCORE: "+ score.ToString(), "score");
	}
}

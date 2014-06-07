using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	public GUISkin skin;
	int score = 0;

	void Awake() {
		if (PlayerPrefs.HasKey("score")) {
			score = PlayerPrefs.GetInt("score");
		}
	}

	void OnGUI() {
		GUI.skin = skin;
		GUI.Label(new Rect(0,0, Screen.width / 2,Screen.height / 4),"SCORE: "+ score.ToString(), "score");
	}
}

using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	public GUISkin skin;
	int score;
	// Use this for initialization
	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;

		string scoreText = "SCORE: "+ score.ToString();
		GUI.Label(new Rect(10,10, sw / 2, sh / 4),scoreText,"score");
	}
}

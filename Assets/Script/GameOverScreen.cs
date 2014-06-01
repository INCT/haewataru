using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

	public GUISkin skin;
	int score;
	int windows;
	string state;

	void ScoreKeeper(int endScore,int throughWindows) {
		score = endScore;
		windows = throughWindows;
	}

	void EndGame() {
		enabled = true;
		state = "End Game";
		StartCoroutine("processing");
		Rect rect = new Rect(Screen.width/4, Screen.height/2,Screen.width/2,Screen.height/4);
		bool isClicked = GUI.Button(rect,"タイトル画面へ");
		if (isClicked) {
			Application.LoadLevel("Title");
		}
	}

	IEnumerator processing() {
		yield return new WaitForSeconds(3.0f);
		state = "";
		yield return new WaitForSeconds(0.5f);
		state = "Show Score";
	}

	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;

		if (state == "End Game") {
			Rect rect = new Rect(0, 0.2f * sh, sw, 0.3f * sh);
			GUI.Label(rect, "GAME OVER!", "message");
		}
		if (state == "Show Score") {
			Rect rect = new Rect(0, 0, sw, 0.3f * sh);
			GUI.Label(rect, "Window:"+windows.ToString()+"\nSCORE: " + score.ToString(), "gameover");
			rect = new Rect(0, sh / 2, sw, sh / 4);
			GUI.Label(rect, "Click to Exit", "result");
		}
	}
}

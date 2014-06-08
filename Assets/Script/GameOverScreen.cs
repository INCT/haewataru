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
	}
	IEnumerator processing() {
		yield return new WaitForSeconds(3.0f);
		state = "";
		yield return new WaitForSeconds(0.5f);
		state = "Show Score";
	}
	void Score(int result) {
		score = result;
		PlayerPrefs.SetInt("score",score);
	}
	void Windows(int result) {
		windows = result;
	}

	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;

		if (state == "End Game") {
			Rect rect = new Rect(0, 0.2f * sh, sw, 0.3f * sh);
			GUI.Label(rect, "GAME OVER!", "GameOver");
		}
		if (state == "Show Score") {
			Rect rect = new Rect(0, 0, sw, 0.3f * sh);
			GUI.Label(rect, "通り抜けた窓:"+windows.ToString()+"枚"+"\nスコア: " + score.ToString(), "ShowScore");
			bool isClicked = GUI.Button(new Rect(sw/4, sh/2,sw/2,sh/4),"タイトル画面へ");
			if (isClicked) {
				Application.LoadLevel("Title");
				Destroy(this.gameObject);
			}
		}
	}
}

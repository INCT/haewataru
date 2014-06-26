using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

	public GUISkin skin;
	public Texture2D back_im;

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
		for (int i = 0; i < 5; i++) {
			if (score > PlayerPrefs.GetInt("score"+i)) {
				PlayerPrefs.SetInt("score"+i,score);
				break;
			}
		}
	}
	void Windows(int result) {
		windows = result;
	}

	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;

		if (state == "End Game") {
			if(PlayerPrefs.GetString("isDiving") =="ON"){
				GUI.Label(new Rect(-sw/4,sh/4, sw, sh), "GAME OVER!", "GameOver");
				GUI.Label(new Rect(sw/4,sh/4, sw, sh), "GAME OVER!", "GameOver");
			} else {
				GUI.Label(new Rect(0, 0.2f * sh, sw, 0.3f * sh), "GAME OVER!", "GameOver");
			}
		}
		if (state == "Show Score") {
			if(PlayerPrefs.GetString("isDiving") =="ON"){
				GUI.Label(new Rect(-sw/4,sh/4, sw, sh), "通り抜けた窓:"+windows.ToString()+"枚"+"\nスコア: " + score.ToString(), "ShowScore");
				GUI.Label(new Rect(sw/4,sh/4, sw, sh), "通り抜けた窓:"+windows.ToString()+"枚"+"\nスコア: " + score.ToString(), "ShowScore");
			} else {
				GUI.Label(new Rect(0, 0, sw, 0.3f * sh), "通り抜けた窓:"+windows.ToString()+"枚"+"\nスコア: " + score.ToString(), "ShowScore");
			}/*
			if (GUI.Button(new Rect(sw/4, sh/2,sw/2,sh/4),"タイトル画面へ")) {
				Application.LoadLevel("Title");
				Destroy(this.gameObject);
			}*/
			GUILayout.BeginArea(new Rect(sw/4,sh/2,sw/2,sh/2));
			if (GUILayout.Button(back_im,GUILayout.MinHeight(sh/6))) {
				Application.LoadLevel("Title");
				Destroy(this.gameObject);
			}
			GUILayout.EndArea();
		}
	}
}

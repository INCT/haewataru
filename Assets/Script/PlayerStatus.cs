using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	//Skin
	public GUISkin skin;
	//プレイヤーのステータス
	string state;
	float time;
	int score;
	int windows;

	void Update () {
		time += Time.deltaTime;
	}
	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;
		GUI.Label(new Rect(0,0, sw / 2,sh/ 4),"SCORE: "+ score.ToString(), "Score");
		GUI.Label(new Rect(0, 0, sw, sh), "Time: " + Mathf.Ceil(time).ToString(), "Time");
	}
	void PlusScore(int amount) {
		state = "Plus";
		score += amount;
		state = "";
	}
	void MinusScore(int amount) {
		state = "Minus";
		score -= amount;
		state = "";
	}
	void Goal() {
		state = "Goal";
		windows += 1;
		score += 100;
		state = "";
	}
	void ApplyDamage() {
		if (state != "Death") {
			GameObject.FindWithTag("Player").BroadcastMessage("EndGame");
			GameObject.FindWithTag("GameController").BroadcastMessage("EndGame");
			GameObject.FindWithTag("GameController").BroadcastMessage("Score", score);
			GameObject.FindWithTag("GameController").BroadcastMessage("Windows", windows);
			enabled = false;
			state ="Death";
		}
	}

	void StartGame() {
		enabled = true;
		time = 0.0f;
		score =0;
		windows = 0;
	}
}

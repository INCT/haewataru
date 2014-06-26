using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	//Skin
	public GUISkin skinNormal;
	public GUISkin skinDive;
	//プレイヤーのステータス
	string state;
	float time;
	//体力の上限(初期値)
	public float lifeMax = 100f;
	float life;
	int score;
	//通過した窓の数
	int windows;

	void Start() {
		life = lifeMax;
	}

	void Update () {
		time += Time.deltaTime;
		life -= Time.deltaTime;
		if (life < 0 && state != "Death") {
			state ="Death";
			GameObject.FindWithTag("Player").BroadcastMessage("Fall");
		}

		if (state == "Death") {
			GameObject.FindWithTag("Player").BroadcastMessage("EndGame");
			GameObject.FindWithTag("GameController").BroadcastMessage("EndGame");
			//スコアを計算
			GameObject.FindWithTag("GameController").BroadcastMessage("Score", score+time);
			GameObject.FindWithTag("GameController").BroadcastMessage("Windows", windows);
			enabled = false;
		}
	}
	void OnGUI() {
		int sw = Screen.width;
		int sh = Screen.height;
		if(PlayerPrefs.GetString("isDinving") =="ON"){
			GUI.skin = skinDive;
			GUI.Label(new Rect(0,0, sw, sh),"SCORE: "+ score.ToString(), "ScoreL");
			GUI.Label(new Rect(0,0, sw, sh),"SCORE: "+ score.ToString(), "ScoreR");
			GUI.Label(new Rect(0,0, sw, sh), "Life: " + Mathf.Ceil(life).ToString(), "LifeL");
			GUI.Label(new Rect(0,0, sw, sh), "Life: " + Mathf.Ceil(life).ToString(), "LifeR");
		} else {
			GUI.skin = skinNormal;
			GUI.Label(new Rect(0,0, sw, sh),"SCORE: "+ score.ToString(), "Score");
			GUI.Label(new Rect(0,0, sw, sh), "Life: " + Mathf.Ceil(life).ToString(), "Life");
		}
	}
	void GetItem(int amount) {
		state = "Plus";
		score += amount;
		if(lifeMax - life < amount) {
			life = lifeMax;
		} else {
			life += amount;
		}
		state = "";
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

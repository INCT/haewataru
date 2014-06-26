using UnityEngine;
using System.Collections;

public class PlayerStatusTest : MonoBehaviour {
	//Skin
	public GUISkin skinNormal;
	public GUISkin skinDive;
	//プレイヤーのステータス
	string state;
	float time;
	//体力の上限(初期値)
	public float lifeMax = 50f;
	float life;
	int score;
	//通過した窓の数
	int windows;

	void Start() {
		life = lifeMax;
	}

	void Update () {
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
}

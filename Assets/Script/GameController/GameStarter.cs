using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour {

	public GUISkin skinNormal;
	public GUISkin skinDive;
	public AudioClip countdownSE;

	float timer = 3.5f;

	void Start () {
		// スリーカウントの3.0秒と、開始時の余裕を持たせるための0.5秒
		timer = 3.5f;
		audio.PlayOneShot(countdownSE);
	}
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0.0) {
			//BroadcastMessage("StartGame");
			if(PlayerPrefs.GetString ("isDiving") == "OFF")
				GameObject.FindWithTag("Player").BroadcastMessage("StartGame1");
			else if (PlayerPrefs.GetString ("isDiving") == "ON")
				GameObject.FindWithTag("Player").BroadcastMessage("StartGame2");

			GameObject.FindWithTag("GameController").BroadcastMessage("StartGame");
			if (GameObject.FindWithTag("MoveObject")) {
				GameObject.FindWithTag("MoveObject").BroadcastMessage("StartGame");
			}

			enabled = false;
		}
	}
	void OnGUI() {
		if (timer > 3.0 || timer <= 0.0) return;
		int sw = Screen.width;
		int sh = Screen.height;
		if (PlayerPrefs.GetString ("isDiving") == "OFF") {
			GUI.skin = skinNormal;
			// タイマーを繰り上げで整数に変換し、文字列へ変換
			string text = Mathf.CeilToInt(timer).ToString();
			// タイマーの小数点部分のみを切り出し、各カウントにおけるアルファ値のフェードアウト
			GUI.color = new Color(1, 1, 1, timer - Mathf.FloorToInt(timer));
			GUI.Label(new Rect(0, sh / 4, sw, sh / 2), text, "count");
		} else {
			GUI.skin = skinDive;
			// タイマーを繰り上げで整数に変換し、文字列へ変換
			string text = Mathf.CeilToInt(timer).ToString();
			// タイマーの小数点部分のみを切り出し、各カウントにおけるアルファ値のフェードアウト
			GUI.color = new Color(1, 1, 1, timer - Mathf.FloorToInt(timer));
			GUI.Label(new Rect(-sw/4, sh / 4, sw, sh / 2), text, "count");
			GUI.Label(new Rect(sw/4, sh / 4, sw, sh / 2), text, "count");
		}
	}
}

using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour {
	//
	public GUISkin skin;
	public AudioClip countdownSE;

	float timer = 3.5f;

	void Start () {
		// スリーカウントの3.0秒と、開始時の余裕を持たせるための0.5秒。
		timer = 3.5f;
		audio.PlayOneShot(countdownSE);
	}
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0.0) {
			//BroadcastMessage("StartGame");
			GameObject.FindWithTag("Player").BroadcastMessage("StartGame");
			//GameObject.FindWithTag("MoveObject").BroadcastMessage("StartGame");
			enabled = false;
		}
	}
	void OnGUI() {
		if (timer > 3.0 || timer <= 0.0) return;
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;
		Rect rect = new Rect(0, sh / 4, sw, sh / 2);
		// タイマーを繰り上げで整数に変換し、文字列へ変換する。
		string text = Mathf.CeilToInt(timer).ToString();
		// タイマーの小数点部分のみを切り出し、各カウントにおけるアルファ値のフェードアウトを表現する。
		GUI.color = new Color(1, 1, 1, timer - Mathf.FloorToInt(timer));
		GUI.Label(rect, text, "count");
	}
}

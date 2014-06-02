using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	int score = 0;
	//Effects
	public GameObject plusFx;
	public GameObject minusFx;
	public GameObject deathFx;
	//SE
	public AudioClip plusSE;
	public AudioClip minusSE;
	public AudioClip deathSE;
	//Skin
	public GUISkin skin;
	//プレイヤーのステータス
	string state;

	void Update () {
		GameObject.FindWithTag("GameController").SendMessage("ScoreKeeper",score);
	}

	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;
		Rect rect = new Rect(0,0.2f * sh, sw, 0.3f * sh);
		float alpha = 1.0f;
		//Mathf.Clamp01() 0 から1 の値を返す
		float dim = Mathf.Clamp01(Time.deltaTime);

		if (state == "Plus") {
			alpha -= dim;
			GUI.color = new Color(0,1,0, alpha);
			GUI.Label(rect,"POINT UP","masseage");
		}
		if (state == "Miunus") {
			alpha -= dim;
			GUI.color = new Color(0,1,0, alpha);
			GUI.Label(rect,"POINT DOWN","masseage");
		}		
		if (state == "Death") {
			alpha -= dim;
			GUI.color = new Color(0,1,0, alpha);
			GUI.Label(rect,"Death","message");
		}
	}
	void PlusScore(int amount) {
		score += amount;
		state = "Plus";
		Instantiate(plusFx, transform.position, transform.rotation);
		audio.PlayOneShot(plusSE);
		StartCoroutine("processing");
		state = "";
	}
	void MinusScore(int amount) {
		score -= amount;
		state = "Minus";
		Instantiate(minusFx, transform.position, transform.rotation);
		audio.PlayOneShot(minusSE);
		StartCoroutine("processing");
		state = "";
	}
	void GameOver() {
		Instantiate(deathFx, transform.position, transform.rotation);
		audio.PlayOneShot(deathSE);
		GameObject.FindWithTag("GameController").BroadcastMessage("EndGame");
		Destroy(gameObject);
		enabled = false;
	}
	IEnumerator processing() {
		yield return new WaitForSeconds(3.0f);
	}
	void StartGame() {
		enabled = true;
	}
}

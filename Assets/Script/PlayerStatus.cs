using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
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
		GUI.Label(new Rect(0,0, sw / 2,sh/ 4),"SCORE: "+ score.ToString(), "Score");
		GUI.Label(new Rect(0, 0, sw, sh), "Time: " + Mathf.Ceil(time).ToString(), "Time");
	}
	void PlusScore(int amount) {
		score += amount;
		state = "Plus";
		Instantiate(plusFx, transform.position, transform.rotation);
		audio.PlayOneShot(plusSE);
		StartCoroutine("Processing");
		state = "";
	}
	void MinusScore(int amount) {
		score -= amount;
		state = "Minus";
		Instantiate(minusFx, transform.position, transform.rotation);
		audio.PlayOneShot(minusSE);
		StartCoroutine("Processing");
		state = "";
	}
	void WindowThrough() {
		windows += 1;
		score += 20;
		state = "Through";
		Instantiate(plusFx, transform.position, transform.rotation);
		audio.PlayOneShot(plusSE);
		StartCoroutine("Processing");
		state = "";
	}
	IEnumerator Processing() {
		yield return new WaitForSeconds(3.0f);
	}
	void ApplyDamage() {
		if (state != "Death") {

			rigidbody.AddForce(Vector3.back * 15.0f, ForceMode.Impulse);
			Instantiate(deathFx, transform.position, transform.rotation);
			audio.PlayOneShot(deathSE);
			GameObject.FindWithTag("Player").BroadcastMessage("EndGame");
			GameObject.FindWithTag("GameController").BroadcastMessage("EndGame");
			//Destroy(gameObject);
			enabled = false;
			state ="Death";
		}
	}
	IEnumerator KillDelay() {
		yield return new WaitForSeconds(0.4f);
	}

	
	void StartGame() {
		enabled = true;
		time = 0.0f;
		score =0;
		windows = 0;
	}
}

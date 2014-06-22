using UnityEngine;
using System.Collections;

public class PlayerFx : MonoBehaviour {
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
	
	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;
		Rect rect = new Rect(0,0.2f * sh, sw, 0.3f * sh);

		if (state == "Plus") {
			float alpha = 1.0f;
			//Mathf.Clamp01() 0 から1 の値を返す
			float dim = Mathf.Clamp01(Time.deltaTime);
			alpha -= dim;
			GUI.color = new Color(0,1,0, alpha);
			GUI.Label(rect,"POINT UP","masseage");
		}
		if (state == "Miunus") {
			float alpha = 1.0f;
			//Mathf.Clamp01() 0 から1 の値を返す
			float dim = Mathf.Clamp01(Time.deltaTime);
			alpha -= dim;
			GUI.color = new Color(0,1,0, alpha);
			GUI.Label(rect,"POINT DOWN","masseage");
		}		
		if (state == "Death") {
			float alpha = 1.0f;
			//Mathf.Clamp01() 0 から1 の値を返す
			float dim = Mathf.Clamp01(Time.deltaTime);
			alpha -= dim;
			GUI.color = new Color(0,1,0, alpha);
			GUI.Label(rect,"Death","message");
		}
		if (state == "Goal") {
			float alpha = 1.0f;
			//Mathf.Clamp01() 0 から1 の値を返す
			float dim = Mathf.Clamp01(Time.deltaTime);
			alpha -= dim;
			GUI.color = new Color(0,1,0, alpha);
			GUI.Label(rect,"GOAL","message");
		}
	}
	void PlusScore(int amount) {
		state = "Plus";
		Instantiate(plusFx, transform.position, transform.rotation);
		audio.PlayOneShot(plusSE);
		StartCoroutine("Processing");
		state = "";
	}
	void MinusScore(int amount) {
		state = "Minus";
		Instantiate(minusFx, transform.position, transform.rotation);
		audio.PlayOneShot(minusSE);
		StartCoroutine("Processing");
		state = "";
	}
	void Goal() {
		state = "Goal";
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
			this.rigidbody.AddForce(Vector3.back * 100f, ForceMode.VelocityChange);
			Instantiate(deathFx, transform.position, transform.rotation);
			audio.PlayOneShot(deathSE);
			enabled = false;
			state ="Death";
		}
	}
	IEnumerator KillDelay() {
		yield return new WaitForSeconds(0.4f);
	}

	void StartGame() {
		enabled = true;
	}
}

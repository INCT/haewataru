using UnityEngine;
using System.Collections;

public class TimeKeeper : MonoBehaviour {

	public GUISkin skin;
	double time;

	void Update () {
		time += Time.deltaTime;
	}
	void StartGame() {
		enabled = true;
		time = 0.0;
	}
	void EndGame() {
		enabled = false;
	}
	
	void OnGUI() {
	GUI.skin = skin;
	Rect rect = new Rect(0, 0, Screen.width, Screen.height);
	GUI.Label(rect, "Time: " + time.ToString(), "Time");
	}
}
using UnityEngine;
using System.Collections;

public class Option : MonoBehaviour {
	public GUISkin skin;
	public Texture2D dive_on;
	public Texture2D dive_off;
	Texture2D dive_im;
	public Texture2D back_im;

	string isDiving = "ON";

	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;

		isDiving = PlayerPrefs.GetString ("isDiving");

		if (!PlayerPrefs.HasKey ("isDiving")) {
						isDiving = "OFF";
						dive_im = dive_off;
		}

		if (isDiving == "ON")
						dive_im = dive_on;
		else 
			dive_im = dive_off;


		GUILayout.BeginArea(new Rect(sw/4,sh/5*2,sw/2,sh/3));
		//if (GUILayout.Button("Durovis Dive : " + isDiving,GUILayout.MinHeight(sh/6))) {
		if (GUI.Button(new Rect(0,0,sw/2,sh/3), dive_im)) {
			if(isDiving == "OFF"){
				isDiving = "ON";
				PlayerPrefs.SetString("isDiving",isDiving);
				dive_im = dive_on;
				//Debug.Log("ON");
			}
			else if(isDiving == "ON"){
				isDiving = "OFF";
				PlayerPrefs.SetString("isDiving",isDiving);
				dive_im = dive_off;
				//Debug.Log("OFF");
			}
		}
		GUILayout.EndArea();

		GUILayout.BeginArea(new Rect(sw/4,sh/5*4,sw/2,sh/4));

		if (GUILayout.Button(back_im,GUILayout.MinHeight(sh/10))) {
			Application.LoadLevel("Title");
		}

		GUILayout.EndArea();
	}
}

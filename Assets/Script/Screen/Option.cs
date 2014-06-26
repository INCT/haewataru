using UnityEngine;
using System.Collections;

public class Option : MonoBehaviour {
	public GUISkin skin;
	public Texture2D back_im;

	string isDiving = "ON";

	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;

		isDiving = PlayerPrefs.GetString ("isDiving");

		if(!PlayerPrefs.HasKey("isDiving"))
			isDiving = "OFF";

		GUILayout.BeginArea(new Rect(sw/4,sh/2,sw/2,sh/3));
		if (GUILayout.Button("Durovis Dive : " + isDiving,GUILayout.MinHeight(sh/6))) {
			if(isDiving == "OFF"){
				isDiving = "ON";
				PlayerPrefs.SetString("isDiving",isDiving);
				Debug.Log("ON");
			}
			else if(isDiving == "ON"){
				isDiving = "OFF";
				PlayerPrefs.SetString("isDiving",isDiving);
				Debug.Log("OFF");
			}
		}
		GUILayout.EndArea();

		GUILayout.BeginArea(new Rect(sw/4,sh/4*3,sw/2,sh/3));

		if (GUILayout.Button(back_im,GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Title");
		}

		GUILayout.EndArea();
	}
}

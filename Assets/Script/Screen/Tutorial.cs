using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {
	//public GUISkin skin;
	public GameObject GameObjectPrefab;

	void Start(){
		Instantiate(GameObjectPrefab,new Vector3(0,0,0), Quaternion.identity);
	}
	/*
	void OnGUI() {
		GUI.skin = skin;
		int sw = Screen.width;
		int sh = Screen.height;
		GUILayout.BeginArea(new Rect(sw/4,sh/2,sw/2,sh/2));
		if (GUILayout.Button("戻る",GUILayout.MinHeight(sh/6))) {
			Application.LoadLevel("Title");
		}
		GUILayout.EndArea();
	}*/
}

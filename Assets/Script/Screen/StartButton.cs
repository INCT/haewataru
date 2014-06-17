using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
	public GameObject GameObjectPrefab;

	void OnMouseDown () {
		Application.LoadLevel("Stage1");
		Instantiate(GameObjectPrefab,new Vector3(0,0,0), Quaternion.identity);
	}
}

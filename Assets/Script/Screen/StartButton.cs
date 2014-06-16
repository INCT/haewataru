using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
	public GameObject GameObjectPrefab;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown () {
		Application.LoadLevel("Stage1");
		Instantiate(GameObjectPrefab,new Vector3(0,0,0), Quaternion.identity);
	}
}

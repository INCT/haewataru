using UnityEngine;
using System.Collections;

public class MoveCircle : MonoBehaviour {

	public float t = 0;

	void Update () {
		transform.Translate (Mathf.Sin(t)*2f, Mathf.Cos(t)*2f, 0);
		t += 0.01f;
	}

	void StartGame() {
		enabled = true;
	}
}

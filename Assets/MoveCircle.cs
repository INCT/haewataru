using UnityEngine;
using System.Collections;

public class MoveCircle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float t = 0;

	// Update is called once per frame
	void Update () {
		transform.Translate (Mathf.Sin(t)*2f, Mathf.Cos(t)*2f, 0);
		t += 0.01f;
	}
}

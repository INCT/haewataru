using UnityEngine;
using System.Collections;

public class Horming : MonoBehaviour {

	GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("Main Camera");
	}


	// Update is called once per frame
	void Update () {/*
		transform.localPosition.x = target.transform.localPosition.x;
		transform.localPosition.y = target.transform.localPosition.y;
		transform.localPosition.z = target.transform.localPosition.z + 1;*/
	}
}

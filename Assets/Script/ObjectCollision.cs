using UnityEngine;
using System.Collections;

public class ObjectCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("Collisioned!!");
		Destroy (gameObject);
	}

	//void OnCpllision
}

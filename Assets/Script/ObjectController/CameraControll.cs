using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {

	private GameObject player = null;
	public Vector3 offset;

	void Start () {
		player = GameObject.FindWithTag("Player");
		offset = transform.position - player.transform.position;

	}

	void Update () {
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), 0.07f);
	}
}

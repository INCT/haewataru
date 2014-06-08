using UnityEngine;
using System.Collections;

public class ObjectCollision : MonoBehaviour {
	private void OnCollisionEnter(Collision collision)
	{
		GameObject.FindWithTag("Player").BroadcastMessage("ApplyDamage");
		GameObject.FindWithTag("GameController").BroadcastMessage("ApplyDamage");
	}
}

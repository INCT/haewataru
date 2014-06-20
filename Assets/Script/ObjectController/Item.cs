using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public GameObject itemFx;
	public AudioClip itemSE;
	public int amount;
	public char itemType = 'A';
	bool cleared;
	void Start () {
		cleared = false;
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "PlayerModel" && cleared == false) {
				cleared = true;
				GameObject.FindWithTag("Player").BroadcastMessage("LifePlus",amount);

		}
	}
}


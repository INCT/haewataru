using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public GameObject itemFx;
	public AudioClip itemSE;
	public int amount;
	public string itemType = 'Apple';
	bool cleard;
	void Start () {
		cleard = false;
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "PlayerModel" && cleared == false) {

			switch (itemType) {
				case Apple:
				cleared = true;
				GameObject.FindWithTag("Player").BroadcastMessage("LifePlus",amount);
				break;
			}

		}
	}


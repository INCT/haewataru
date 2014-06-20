using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public GameObject itemFx;
	public AudioClip itemSE;
	public int amount = 100;
	public char itemType = 'A';
	bool cleared = false;
	void Start () {
		cleared = false;
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "PlayerModel" && cleared == false) {
				cleared = true;
				//GameObject.FindWithTag("Player").BroadcastMessage("PlusScore",amount);
				Object.Destroy(this);
		}
	}
}


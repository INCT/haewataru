using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	bool cleared;
	// Use this for initialization
	void Start () {
		cleared = false;
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "PlayerModel") {
			cleared = true;
			GameObject.FindWithTag("Player").BroadcastMessage("Goal");
		}
	}
	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "PlayerModel") {
			//暗転して次のレベルへ
		}
	}
}

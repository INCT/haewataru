using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public int num;
	bool cleared;
	// Use this for initialization
	void Start () {
		cleared = false;
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "PlayerModel" && cleared == false) {
			cleared = true;
			GameObject.FindWithTag("Player").BroadcastMessage("Goal");
		}
	}
	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "PlayerModel") {
			//暗転して次のステージへ
			Application.LoadLevel("Stage"+num);
		}
	}
}

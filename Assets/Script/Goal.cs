using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public int NextStageNum;
	bool cleared;
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
			//カメラフェードクラスを使用
			CameraFade.StartAlphaFade(Color.white,false, 1f, 1f, () => {
				Application.LoadLevel("Stage"+NextStageNum);
				});
		}
	}
}

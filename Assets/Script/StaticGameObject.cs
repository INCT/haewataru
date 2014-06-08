using UnityEngine;
using System.Collections;

public class StaticGameObject : MonoBehaviour {
	private static bool created = false;
	void Awake () {
		if (!created) {
			DontDestroyOnLoad(this);
			created = true;
		} else {
			Destroy(this.gameObject);
			created = false;
		}
		
	}
}

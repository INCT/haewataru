using UnityEngine;
using System.Collections;

public class StaticGameObject : MonoBehaviour {
	void Awake () {
		DontDestroyOnLoad(this);
	}
}

using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	public float intervalMin = 0.5f;
	public float intervalMax = 1.5f;
	public GameObject prefab;
	
	void Update () {
		StartCoroutine("waitTime");
		Vector3 position = new Vector3(Random.Range(-20,20), Random.Range(3,30), Random.Range(-20,20));
		Instantiate(prefab, position, Random.rotation);
	}
	IEnumerator waitTime() {
		yield return new WaitForSeconds(Random.Range(intervalMin, intervalMax));
	}
}

using UnityEngine;
using System.Collections;

public class bgmove : MonoBehaviour {
	void Update() {
		transform.Translate(Vector3.right * Time.deltaTime);
	}
}

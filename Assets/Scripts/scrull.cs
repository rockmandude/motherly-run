using UnityEngine;
using System.Collections;

public class scrull : MonoBehaviour {

	public float speed = 0.5f;
	
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);

		renderer.material.mainTextureOffset = offset;
	
	}
}

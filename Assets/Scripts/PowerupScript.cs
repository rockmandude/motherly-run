using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	HUDScrept hud;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScrept>();
			hud.IncreaseScore (10);
			Destroy (this.gameObject);
		}
	}

}


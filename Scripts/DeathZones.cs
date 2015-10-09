using UnityEngine;
using System.Collections;

public class DeathZones : MonoBehaviour {

	public GameObject Player;

	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}

	void OnTriggerEnter(Collider Player)
	{
		Debug.Log ("Colliding with Player");
		Application.LoadLevel(Application.loadedLevel);
	}
}

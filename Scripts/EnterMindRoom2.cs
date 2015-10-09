using UnityEngine;
using System.Collections;

public class EnterMindRoom2 : MonoBehaviour {

	public GameObject Player;

	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	
	void OnTriggerEnter(Collider Player)
	{
		Debug.Log ("Colliding with something");

			Application.LoadLevel("MindRoomMazeRunner");

	}

}

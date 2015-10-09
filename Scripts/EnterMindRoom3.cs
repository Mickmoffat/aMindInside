using UnityEngine;
using System.Collections;

public class EnterMindRoom3 : MonoBehaviour {

	public GameObject Player;
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void OnTriggerEnter(Collider Player)
	{
		Application.LoadLevel("MindRoomFratHouse");
	}
}
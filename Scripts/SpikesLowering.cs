using UnityEngine;
using System.Collections;

public class SpikesLowering : MonoBehaviour {

	public GameObject Spikes;
	public GameObject Player;
	public float LoweringValue;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if(Spikes.activeSelf)
		{
			Spikes.transform.Translate(new Vector3(0.0f, LoweringValue*-1.0f, 0.0f));
		}

	}

	void OnTriggerEnter(Collider Player)
	{
		Debug.Log ("Colliding with something");
			Application.LoadLevel(Application.loadedLevel);
	}
}

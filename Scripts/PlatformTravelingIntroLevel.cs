using UnityEngine;
using System.Collections;

public class PlatformTravelingIntroLevel : MonoBehaviour {

	public Transform platformOBJ;
	public Transform PosA;
	public Transform PosB;
	public Vector3 newPosition;
	public string currState;
	public float smooth;
	public float resetTimer;

	// Use this for initialization
	void Start () {
		changeTarget();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		platformOBJ.position = Vector3.Lerp (platformOBJ.position, newPosition, smooth * Time.deltaTime);
	}

	void changeTarget()
	{
		if(currState == "Move to PosA")
		{
			currState = "Move to PosB";
			newPosition = PosB.position;
		} else if(currState == "Move to PosB")
		{
			currState = "Move to PosA";
			newPosition = PosA.position;
		} else if(currState == "")
		{
			currState = "Move to PosB";
			newPosition = PosB.position;
		}
		Invoke ("changeTarget", resetTimer);
	}
}

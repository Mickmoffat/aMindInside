using UnityEngine;
using System.Collections;

public class BridgeRoomDropBlocks : MonoBehaviour {

	public GameObject obj1Change;
	public GameObject obj2Change;
	public GameObject obj3Change;
	public GameObject obj4Change;
	public GameObject obj5Change;
	public GameObject obj6Change;
	public GameObject obj7Change;

	public int randMin;
	public int randMax;

	private int rand;
	private Vector3 increaseValue = new Vector3(0,0,0);


	void Start()
	{
		// Fixes the rand min and max if initialised too high or not at all
		if(randMax > 10){
			randMax = 5;
			Debug.Log ("Changed randMax to 5");
		}
		if(randMin < 1){
			randMin = 1;
			Debug.Log ("Changed randMin to 1");
		}
	}
	
	void OnTriggerStay(Collider other)
	{
		Debug.Log ("Player entered the collider");
		// Pass in all the gameobjects into the dropBlock function with a random force variable
		dropBlock (obj1Change);
		dropBlock (obj2Change);
		dropBlock (obj3Change);
		dropBlock (obj4Change);
		dropBlock (obj5Change);
		dropBlock (obj6Change);
		dropBlock (obj7Change);

	}

	// Function to drop the block at a random speed passed from the on trigger enter
	void dropBlock (GameObject block)
	{
		increaseValue = new Vector3(0, rand*1.0f,0);
		rand = -Random.Range (randMin, randMax);
		block.transform.localPosition += increaseValue * Time.deltaTime;
	}
	
	
}

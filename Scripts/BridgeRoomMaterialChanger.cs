using UnityEngine;
using System.Collections;

public class BridgeRoomMaterialChanger : MonoBehaviour {

	public GameObject obj1Change;
	public GameObject obj2Change;
	public GameObject obj3Change;
	public GameObject obj4Change;
	public GameObject obj5Change;
	public GameObject obj6Change;
	public GameObject obj7Change;
	//public GameObject objRecover;
	public Material matChanger;
	public Material matRecover;

	// the speed the block falls at, this is timed by the random value between min and max and then multiplied by -1.0f for the Vector3 to create a downwards fall
	public float speed;
	// Sets the different amount the speed will be multiplied by to create a more random dropping effect
	private int randMin;
	private int randMax;
	
	private int rand;
	private Vector3 increaseValue = new Vector3(0,0,0);

	void Start(){
		randMin = 1;
		randMax = 300;
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Player entered the collider");
		obj1Change.GetComponent<Renderer>().material = matChanger;
		obj2Change.GetComponent<Renderer>().material = matChanger;
		obj3Change.GetComponent<Renderer>().material = matChanger;
		obj4Change.GetComponent<Renderer>().material = matChanger;
		obj5Change.GetComponent<Renderer>().material = matChanger;
		obj6Change.GetComponent<Renderer>().material = matChanger;
		obj7Change.GetComponent<Renderer>().material = matChanger;
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

	void OnTriggerExit(Collider other)
	{
		Debug.Log ("Player exited the collider");
		obj1Change.GetComponent<Renderer>().material = matRecover;
		obj2Change.GetComponent<Renderer>().material = matRecover;
		obj3Change.GetComponent<Renderer>().material = matRecover;
		obj4Change.GetComponent<Renderer>().material = matRecover;
		obj5Change.GetComponent<Renderer>().material = matRecover;
		obj6Change.GetComponent<Renderer>().material = matRecover;
		obj7Change.GetComponent<Renderer>().material = matRecover;
	}

	// Function to drop the block at a random speed passed from the on trigger enter
	void dropBlock (GameObject block)
	{
		increaseValue = new Vector3(0, rand*speed*1.0f,0);
		rand = -Random.Range (randMin, randMax);
		block.transform.localPosition += increaseValue * Time.deltaTime;
		if(block.transform.position.y < -10){
			block.SetActive(false);
		}
	}


}

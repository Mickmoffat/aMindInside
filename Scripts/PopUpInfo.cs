using UnityEngine;
using System.Collections;

public class PopUpInfo : MonoBehaviour {

	public GameObject targetTeleport;
	public GameObject targetTeleport2;


	private bool targetPOS1;


	void Start(){
	
		targetPOS1 = true;

	}

	void OnGUI() {

		GUI.Label(new Rect(10, 10, 1000, 2000), "Welcome to the INEXT Facility \n You cannot die \n If you get stuck press 'O' to reset \n Find the chair to enter the mind. \n Press 'T' to teleport to easter egg platform and back.");

	}

	void Update(){
	
		if(Input.GetKeyDown(KeyCode.T) && Application.loadedLevelName == "MainOffice" && targetPOS1 == true)
		{

			transform.position = targetTeleport.transform.position;
			targetPOS1 = false;

		} 
			else if (Input.GetKeyDown(KeyCode.T) && Application.loadedLevelName == "MainOffice" && targetPOS1 == false)
			{
				transform.position = targetTeleport2.transform.position;
				targetPOS1 = true;
			}

	}




}

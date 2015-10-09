using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {

	// two parts of the Flashlight Creates a better flashlight effect
	public Light INEXTLightOuter;
	public Light INEXTLightInner;

	// Variables for flashlight rotation
	public float lookSensitivity = 5f;
	public float xRotation;
	public float yRotation;
	public float currentXRotation;
	public float currentYRotation;
	public float xRotationV;
	public float yRotationV;
	public float lookSmoothDamp = 0.1f;

	// Game Objects that will be activated and deactivated when MindActivator is activated
	public GameObject obj1ON;
	public GameObject obj1OFF;
	public GameObject obj2ON;
	public GameObject obj2OFF;
	public GameObject obj3ON;
	public GameObject obj3OFF;


	// Use this for initialization
	void Start () {
		// Activated the light gameobjects for the flashlight and then turns them off to start the level


		INEXTLightOuter.enabled = false;
		INEXTLightInner.enabled = false;


		// Sets the Game oBjects that can be toggled off so that it synchs with the flashlight
		obj1ON.SetActive(false);
		obj2ON.SetActive(false);
		obj3ON.SetActive(false);
		obj1OFF.SetActive(true);
		obj2OFF.SetActive(true);
		obj3OFF.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {


		// Player presses F = activates the lights and the objects
		if(Input.GetKeyDown(KeyCode.F))
		{
			// Toggles the Light if level not the Main Office
			if(Application.loadedLevelName != "MainOffice"){
				INEXTLightOuter.enabled = !INEXTLightOuter.enabled;
				INEXTLightInner.enabled = !INEXTLightInner.enabled;
			} else { Debug.Log ("The level is the main office, Light does not work here."); }

		}

		// Resets the level if O is pressed
		if(Input.GetKeyDown(KeyCode.O))
		{
			Application.LoadLevel(Application.loadedLevel);
		}

		// Activates the geometry is the left mouse is clicked and increments
		if (Input.GetMouseButtonDown(0))
		{	
			if(obj1ON.activeSelf == false && obj2ON.activeSelf == false && obj3ON.activeSelf == false) 
			{
				obj1ON.SetActive(true);
				obj1OFF.SetActive(false);
			} else if (obj1ON.activeSelf == true && obj2ON.activeSelf == false && obj3ON.activeSelf == false)
			{
				obj2ON.SetActive(true);
				obj2OFF.SetActive(false);
			} else if (obj1ON.activeSelf == true && obj2ON.activeSelf == true && obj3ON.activeSelf == false)
			{
				obj3ON.SetActive(true);
				obj3OFF.SetActive(false);
			}
		}
				


		// Deactivates the Geometry if the right button is clicked and decrements
		if (Input.GetMouseButtonDown(1))
		{	
			if(obj1ON.activeSelf == true && obj2ON.activeSelf == true && obj3ON.activeSelf == true) 
			{
				obj3ON.SetActive(false);
				obj3OFF.SetActive(true);

			} else if (obj1ON.activeSelf == true && obj2ON.activeSelf == true && obj3ON.activeSelf == false)
			{
				obj2ON.SetActive(false);
				obj2OFF.SetActive(true);
			} else if (obj1ON.activeSelf == true && obj2ON.activeSelf == false && obj3ON.activeSelf == false)
			{
				obj1ON.SetActive(false);
				obj1OFF.SetActive(true);
			}
		}

		// For the rotation on the flashlights relative to the mouse
		xRotation -= Input.GetAxis ("Mouse Y") * lookSensitivity;
		yRotation += Input.GetAxis ("Mouse X") * lookSensitivity;
		
		xRotation = Mathf.Clamp (xRotation, -80, 80);
		
		currentXRotation = Mathf.SmoothDamp (currentXRotation, xRotation, ref xRotationV, lookSmoothDamp);
		currentYRotation = Mathf.SmoothDamp (currentYRotation, yRotation, ref yRotationV, lookSmoothDamp);
		
		transform.rotation = Quaternion.Euler (currentXRotation , currentYRotation, 0);
	
	}
}

using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour {

	public Texture2D crossHair;
	public Texture2D crossHairMind;

	void Start ()
	{
		Cursor.visible = false;
	}

	void Update()
	{
		Cursor.visible = false;
	}
	

	void OnGUI()
	{
		float xMin = (Screen.width / 2) - (crossHair.width / 2);
		float yMin = (Screen.height / 2) - (crossHair.height / 2);
		if(Application.loadedLevelName == "MainOffice"){
			GUI.DrawTexture(new Rect(xMin, yMin, crossHair.width, crossHair.height), crossHair);
		} else { GUI.DrawTexture(new Rect(xMin, yMin, crossHairMind.width, crossHairMind.height), crossHairMind); }
	}

}

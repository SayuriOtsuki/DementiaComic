using UnityEngine;
using System.Collections;

public class ClearButton : MonoBehaviour {


	void OnGUI()
	{
		if (GUI.Button(new Rect(70, 700, 300, 50), "Clear Scene"))
		{
			Clear();
		}
		
	}
	
	// Update is called once per frame
	void Clear () {
		
		Application.LoadLevel("Clear");
		
	}
}

using UnityEngine;
using System.Collections;

public class AgainButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(70, 200, 300, 50), "1_Not Drink Again"))
		{
			NotDrinkAgain();
		}

	}
	
	// Update is called once per frame
	void NotDrinkAgain () {

			Application.LoadLevel("1_NotDrink3");

	}
}

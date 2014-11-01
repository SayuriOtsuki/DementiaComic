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

		if (GUI.Button(new Rect(70, 300, 300, 50), "2_Age"))
		{
			AgeAgain();
		}

		if (GUI.Button(new Rect(70, 400, 300, 50), " 3_Typhoon"))
		{
			TyphoonAgain();
		}

	}
	
	// Update is called once per frame
	void NotDrinkAgain () {

			Application.LoadLevel("DC1_NotDrink");

	}

	void AgeAgain () {
		
			Application.LoadLevel("DC2_Age");
		
	}

	void TyphoonAgain () {
		
		Application.LoadLevel("DC3_Typhoon");
		
	}
}

using UnityEngine;
using System.Collections;

public class NotDrinkAdd : MonoBehaviour {

	int comaNun;
	public GameObject coma5;
	public GameObject coma6;
	public GameObject coma7;
	public GameObject coma8;
	public GameObject coma9;
	public GameObject coma10;
	public float cameraZ;

	GameObject MainCam;
	GameObject coma4;


	void Start () {

		cameraZ = this.transform.position.z;

		MainCam = GameObject.Find ("MainCamera");

		coma4 = GameObject.Find ("1_NotDrink_4");


		comaNun = 4;


		
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space)){
			comaNun++;

			Debug.Log(comaNun);

			if(comaNun == 5){
				Instantiate(coma5);
				transform.position = new Vector3(0, -14, cameraZ);
			}
			if(comaNun == 6){
				Instantiate(coma6);
				transform.position = new Vector3(0, -18.394f, cameraZ);
			}
			if(comaNun == 7){
				Instantiate(coma7);
				transform.position = new Vector3(0, -24.648f, cameraZ);
			}
			if(comaNun == 8){
				Instantiate(coma8);
				transform.position = new Vector3(0, -28.99387f, cameraZ);
			}
			if(comaNun == 9){
				Instantiate(coma9);
				transform.position = new Vector3(0, -34.41108f, cameraZ);
			}
			if(comaNun == 10){
				Instantiate(coma10);
				transform.position = new Vector3(0, -39.82828f, cameraZ);
			}

		}



	}

	/*void comaAdd(){

		if (Input.GetKeyUp(KeyCode.Space)){
		
			Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
			Vector3 newVector = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

			Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
			Collider2D collision2d = Physics2D.OverlapPoint(tapPoint);


		}
	}*/


}

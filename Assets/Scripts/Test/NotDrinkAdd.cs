using UnityEngine;
using System.Collections;

public class NotDrinkAdd : MonoBehaviour {

	float comaNum;
	public GameObject coma5;
	public GameObject coma6;
	public GameObject coma7;
	public GameObject coma8;
	public GameObject coma9;
	public GameObject coma10;
	public float cameraZ;
	public float comaGoUnder = -14f;

	public int maxComa = 10;
	public float comaDif = -5.0f;

	GameObject MainCam;
	GameObject coma4;


	void Start () {

		cameraZ = this.transform.position.z;

		MainCam = GameObject.Find ("MainCamera");

		coma4 = GameObject.Find ("1_NotDrink_4");

		comaNum = -1;

	
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space)){
			comaNum = comaNum + 1;
			float comaMove = comaDif*comaNum;

			if(comaNum == 0){
				Instantiate(coma5);
				transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 1){
				Instantiate(coma6);
				transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 2){
				Instantiate(coma7);
				transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 3){
				Instantiate(coma8);
				transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 4){
				Instantiate(coma9);
				transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 5){
				Instantiate(coma10);
				transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
				Debug.Log(comaNum);
			}


		}

		if (Input.touchCount == 1){

			Touch touch = Input.touches[0] ;

			if(touch.phase == TouchPhase.Ended){

				comaNum = comaNum + 1;
				float comaMove = comaDif*comaNum;
			
					if(comaNum == 0){
						Instantiate(coma5);
						transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
						Debug.Log(comaNum);
					}
					if(comaNum == 1){
						Instantiate(coma6);
						transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
						Debug.Log(comaNum);
					}
					if(comaNum == 2){
						Instantiate(coma7);
						transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
						Debug.Log(comaNum);
					}
					if(comaNum == 3){
						Instantiate(coma8);
						transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
						Debug.Log(comaNum);
					}
					if(comaNum == 4){
						Instantiate(coma9);
						transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
						Debug.Log(comaNum);
					}
					if(comaNum == 5){
						Instantiate(coma10);
						transform.position = new Vector3(0, comaGoUnder+comaMove, cameraZ);
						Debug.Log(comaNum);
					}
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

using UnityEngine;
using System.Collections;

public class NotDrinkAdd2 : MonoBehaviour {

	float comaNum;
	public GameObject coma1;
	public GameObject coma2;
	public GameObject coma3;
	public GameObject coma4;
	public GameObject coma5;
	public GameObject coma6;
	public GameObject coma7;
	public GameObject coma8;
	public GameObject coma9;
	public GameObject coma10;
	public float cameraZ;
	public float cameraX;
	public float cameraDif = -5.2f;
	
	public int maxComa = 10;
	
	GameObject MainCam;	
	
	void Start () {

		cameraX = this.transform.position.x;
		cameraZ = this.transform.position.z;

		comaNum = 0;

		MainCam = GameObject.Find ("MainCamera");
			
	}
	
	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space)){
			comaNum++;


			if(comaNum == 1){
				Instantiate(coma2);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 2){
				Instantiate(coma3);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 3){
				Instantiate(coma4);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 4){
				Instantiate(coma5);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 5){
				Instantiate(coma6);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 6){
				Instantiate(coma7);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 7){
				Instantiate(coma8);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 8){
				Instantiate(coma9);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			if(comaNum == 9){
				Instantiate(coma10);
				transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
				Debug.Log(comaNum);
			}
			
			
		}

		if (Input.touchCount == 1){
			
			Touch touch = Input.touches[0] ;
			
			if(touch.phase == TouchPhase.Ended){
			comaNum++;
			
			
				if(comaNum == 1){
					Instantiate(coma2);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 2){
					Instantiate(coma3);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 3){
					Instantiate(coma4);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 4){
					Instantiate(coma5);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 5){
					Instantiate(coma6);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 6){
					Instantiate(coma7);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 7){
					Instantiate(coma8);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 8){
					Instantiate(coma9);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
				if(comaNum == 9){
					Instantiate(coma10);
					transform.position = new Vector3(cameraX, cameraDif*comaNum, cameraZ);
					Debug.Log(comaNum);
				}
			}
			
		}
		
		
		
	}
}

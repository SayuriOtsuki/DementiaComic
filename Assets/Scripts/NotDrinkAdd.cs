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
	GameObject MainCam;
	public float cameraZ = -20.99f;

	void Start () {

		MainCam = GameObject.Find ("MainCamera");
		comaNun = 4;
		
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Space))
		{
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
				transform.position = new Vector3(0, -28.841f, cameraZ);
			}
			if(comaNun == 9){
				Instantiate(coma9);
				transform.position = new Vector3(0, -32.127f, cameraZ);
			}
			if(comaNun == 10){
				Instantiate(coma10);
				transform.position = new Vector3(0, -37.907f, cameraZ);
			}

		}
	}

	//int comaNun;
	/*public GameObject prefab;

	// Use this for initialization
	void Start () {
	 
		//comaNun = 4;

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey(KeyCode.Space))
		{
			//comaNun = comaNun++;
			//if(comaNun == 5){
			Instantiate (prefab, Vector3(0, -20.8, 0), Quaternion.identity);
			//}
		}

	}*/
}

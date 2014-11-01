using UnityEngine;
using System.Collections;

public class ComaMove : MonoBehaviour {
	public float moveSpeed = 0.08f;
	public GameObject comaFirst;
	public float comaDif = 7.0f;
	public float bunkiDif = 1.55f;

	float comaPos;
	float comaFirstX;
	float comaFirstY;
	float comaFirstZ;

	float bunkiPos;
	float bunkiMaruX;
	float bunkiMaruY;

	GameObject bunkiMaru;
	// Use this for initialization
	void Start () {
		bunkiMaru = GameObject.Find ("4koma_bMaru");

		comaFirstX = comaFirst.transform.position.x;
		comaFirstY = comaFirst.transform.position.y;
		comaFirstZ = comaFirst.transform.position.z;
		
		bunkiMaruX = bunkiMaru.transform.position.x;
		bunkiMaruY = bunkiMaru.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Moved){
			
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(0, touchDeltaPosition.y * moveSpeed, 0);
			
			float limit_valueY = Mathf.Clamp (transform.position.y,  0.0f, 21.5f);
			//float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
			transform.position = new Vector3 (0, limit_valueY, transform.position.z);
			
		}
		
		//ぴたっと止める
		if(Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Ended){
			
			//1
			if(comaFirst.transform.position.y < 5.0f){

				comaPos = comaDif*0 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);
				
				bunkiPos = bunkiDif*0 + bunkiMaruX;
				bunkiMaru.transform.position = new Vector3(bunkiPos, bunkiMaruY, 0);
			}
			
			//2
			if(comaFirst.transform.position.y >= 5.0f && comaFirst.transform.position.y  < 11.3f){

				Debug.Log("2");
				comaPos = comaDif*1 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);
				
				bunkiPos = bunkiDif*1 + bunkiMaruX;
				bunkiMaru.transform.position = new Vector3(bunkiPos, bunkiMaruY, 0);
			}
			
			//3
			if(comaFirst.transform.position.y >= 11.3f && comaFirst.transform.position.y < 19.8f){
				comaPos = comaDif*2 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);
				
				bunkiPos = bunkiDif*2 + bunkiMaruX;
				bunkiMaru.transform.position = new Vector3(bunkiPos, bunkiMaruY, 0);
			}
			
			//4
			if(comaFirst.transform.position.y >= 19.8f){
				comaPos = comaDif*3 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);
				
				bunkiPos = bunkiDif*3 + bunkiMaruX;
				bunkiMaru.transform.position = new Vector3(bunkiPos, bunkiMaruY, 0);
			}
		}
	}
}

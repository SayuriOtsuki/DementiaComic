using UnityEngine;
using System.Collections;

public class DC1_comabehaviour : MonoBehaviour {
	public float moveSpeed = 0.08f;
	public GameObject comaFirst;
	public float comaDif = 7.0f;

	float comaMove;
	float comaFirstX;
	float comaFirstY;
	float comaFirstZ;


	// Use this for initialization
	void Start () {
		comaFirstX = comaFirst.transform.position.x;
		comaFirstY = comaFirst.transform.position.y;
		comaFirstZ = comaFirst.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(0, touchDeltaPosition.y * moveSpeed, 0);
			
			float limit_valueY = Mathf.Clamp (transform.position.y,  0.0f, 21.5f);
			//float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
			transform.position = new Vector3 (0, limit_valueY, transform.position.z);
			
			
		}

		if(Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Ended){

			if(comaFirst.transform.position.y < 5.3f){
				comaMove = comaDif*0 + comaFirstY;
				Debug.Log("coma1=" + comaMove);
				comaFirst.transform.position = new Vector3(comaFirstX, comaFirstY, comaFirstZ);
			}

			if(comaFirst.transform.position.y >= 5.3f && comaFirst.transform.position.y  < 11.3f){
				comaMove = comaDif*1 + comaFirstY;
				Debug.Log("coma2=" + comaMove);
				comaFirst.transform.position = new Vector3(comaFirstX, comaMove, comaFirstZ);
			}

			if(comaFirst.transform.position.y >= 11.3f && comaFirst.transform.position.y < 19.8f){
				comaMove = comaDif*2 + comaFirstY;
				Debug.Log("coma3=" + comaMove);
				comaFirst.transform.position = new Vector3(comaFirstX, comaMove, comaFirstZ);
			}

			if(comaFirst.transform.position.y >= 19.8f){
				comaMove = comaDif*3 + comaFirstY;
				Debug.Log( "coma4=" +comaMove);
				comaFirst.transform.position = new Vector3(comaFirstX, comaMove, comaFirstZ);
			}


		}
	}
}

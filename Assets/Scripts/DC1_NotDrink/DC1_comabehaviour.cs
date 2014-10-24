using UnityEngine;
using System.Collections;

public class DC1_comabehaviour : MonoBehaviour {
	public float moveSpeed = 0.08f;
	public GameObject comaFirst;

	float comaFirstZ;
	float comaFirstX;

	// Use this for initialization
	void Start () {
		comaFirstX = comaFirst.transform.position.x;
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
			if(comaFirst.transform.position.y > 5.3f){
				comaFirst.transform.position = new Vector3(comaFirstX, 7.9f, comaFirstZ);
			}

		}
	}
}

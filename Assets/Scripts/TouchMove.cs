using UnityEngine;
using System.Collections;

public class TouchMove : MonoBehaviour {
	public float moveSpeed = 0.08f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(-touchDeltaPosition.x * moveSpeed, -touchDeltaPosition.y * moveSpeed, 0);
			
			float limit_valueY = Mathf.Clamp (transform.position.y,  0.0f, 21.5f);
			//float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
			transform.position = new Vector3 (0, limit_valueY, transform.position.z);
			
			
		}
	}
}

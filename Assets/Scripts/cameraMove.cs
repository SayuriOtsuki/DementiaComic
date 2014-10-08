using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	public float moveSpeed = 0.1f;
	public float cameraZ;

	// Use this for initialization
	void Start () {
		cameraZ = this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = new Vector3(0, Mathf.Clamp(transform.position.y,0,-47.40752f), cameraZ);

		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {

			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(0, -touchDeltaPosition.y * moveSpeed, 0);

			/*Vector3 cameraPos = transform.position;
			cameraPos.y = Mathf.Clamp (cameraPos.y, -8.0f, -47.40752f);
			transform.position = cameraPos;*/


		}
	}

}

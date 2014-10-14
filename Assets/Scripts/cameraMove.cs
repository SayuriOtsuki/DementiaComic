using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	public float moveSpeed = 0.08f;
	public float cameraZ;

	// Use this for initialization
	void Start () {
		cameraZ = this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {

		//Vector3 cameraPos = transform.position;
		//cameraPos.y = Mathf.Clamp (cameraPos.y, -8.0f, -47.40752f);


		if (Input.touchCount >0 && Input.GetTouch (0).phase == TouchPhase.Moved) {

			if(this.transform.position.z == cameraZ){
			//Vector3 nowPos = this.transform.position;
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(0, -touchDeltaPosition.y * moveSpeed, 0);
			}

			else{
				if (Input.touchCount ==1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
					Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
					transform.Translate(-touchDeltaPosition.x * moveSpeed, -touchDeltaPosition.y * moveSpeed, 0);
				}
			}


		}

	}

}

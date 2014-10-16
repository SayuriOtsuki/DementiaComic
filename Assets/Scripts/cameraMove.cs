using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	public float moveSpeed = 0.08f;
	public float cameraZ;

	public float zMin = -19.0f;
	public float zMax = -8.0f;
	public float pinchRate = 10.0f;
	
	private float backDist = 0.0f;


	// Use this for initialization
	void Start () {
		cameraZ = this.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {


		//Vector3 cameraPos = transform.position;
		//cameraPos.y = Mathf.Clamp (cameraPos.y, -8.0f, -47.40752f);

		//transform.position.y = Mathf.Clamp (transform.position.y, -4, 4);
		//transform.position.x = Mathf.Clamp(transform.position.x,-10,10);
		/*if (cameraPos.y < ) {

		}*/	
		if (Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Moved) {

			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(-touchDeltaPosition.x * moveSpeed, -touchDeltaPosition.y * moveSpeed, 0);
					
			float limit_valueY = Mathf.Clamp (transform.position.y, -45.0f, -2.0f);
			float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
			transform.position = new Vector3 (limit_valueX, limit_valueY, transform.position.z);


		}

		if (Input.touchCount == 2) {
			Touch t1 = Input.GetTouch(0);
			Touch t2 = Input.GetTouch(1);
			//2点タッチ開始時の距離を記憶
			if(t2.phase == TouchPhase.Began){
				backDist = Vector2.Distance(t1.position, t2.position);
			}
			//ピンチイン・アウト
			else if (t1.phase == TouchPhase.Moved && t2.phase == TouchPhase.Moved){
				float newDist = Vector2.Distance(t1.position, t2.position);
				float transZ = (newDist - backDist) / pinchRate;
				
				if(transZ != 0){
					
					
					Vector3 newPos = this.transform.position;
					newPos.z += transZ;
					//transform.camera.orthographicSize += transZ; 
					
					//zMin～zMaxの範囲内のみ.
					if(zMin <= newPos.z && newPos.z <= zMax){
						Debug.Log ("newPos.z=" + newPos.z);
						this.transform.position = newPos;
						backDist = newDist;
					}
				}
				
			}
		}

	}

}

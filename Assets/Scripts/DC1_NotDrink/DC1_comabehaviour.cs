using UnityEngine;
using System.Collections;

public class DC1_comabehaviour : MonoBehaviour {
	public float moveSpeed = 0.08f;
	public GameObject comaFirst;
	public float comaDif = 7.0f;

	int comaNum = 2;
	float comaMove;
	float comaFirstX;
	float comaFirstY;
	float comaFirstZ;

	GameObject comaInta;
	DC1_spriteChange dc1SC;

	// Use this for initialization
	void Start () {
		comaInta = GameObject.Find ("4komaTest_66_3");
		dc1SC = comaInta.GetComponent<DC1_spriteChange> ();

		comaFirstX = comaFirst.transform.position.x;
		comaFirstY = comaFirst.transform.position.y;
		comaFirstZ = comaFirst.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Moved) {

			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(0, touchDeltaPosition.y * moveSpeed, 0);
			
			float limit_valueY = Mathf.Clamp (transform.position.y,  0.0f, 21.5f);
			//float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
			transform.position = new Vector3 (0, limit_valueY, transform.position.z);
			
			
		}*/

		if(Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Moved){

			if(comaFirst.transform.position.y == 14){
				if(comaNum >= 8){
					Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
					transform.Translate(0, touchDeltaPosition.y * moveSpeed, 0);
					
					float limit_valueY = Mathf.Clamp (transform.position.y,  0.0f, 21.5f);
					//float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
					transform.position = new Vector3 (0, limit_valueY, transform.position.z);
				}
			}
			else{
				Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
				transform.Translate(0, touchDeltaPosition.y * moveSpeed, 0);
				
				float limit_valueY = Mathf.Clamp (transform.position.y,  0.0f, 21.5f);
				//float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
				transform.position = new Vector3 (0, limit_valueY, transform.position.z);

			}

		}

		if(Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Ended){

			if(comaFirst.transform.position.y < 5.3f){
				comaMove = comaDif*0 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaMove, comaFirstZ);
			}

			if(comaFirst.transform.position.y >= 5.3f && comaFirst.transform.position.y  < 11.3f){
				comaMove = comaDif*1 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaMove, comaFirstZ);
			}

			if(comaFirst.transform.position.y >= 11.3f && comaFirst.transform.position.y < 19.8f){
				comaMove = comaDif*2 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaMove, comaFirstZ);
			}

			if(comaFirst.transform.position.y >= 19.8f){
				comaMove = comaDif*3 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaMove, comaFirstZ);
			}


		}

		if(comaFirst.transform.position.y == 14){

			if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Ended) {

				Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Collider2D collition2d  = Physics2D.OverlapPoint(tapPoint);
				
				if (collition2d) {
					RaycastHit2D hitObject = Physics2D.Raycast(tapPoint,-Vector2.up);
					
					if (hitObject) {
						if(hitObject.collider.gameObject.name == "4komaTest_66_3"){
							comaNum++;
							dc1SC.SpriteChangePre(comaNum);
						}
					}
				}

			}
		}
	}
}

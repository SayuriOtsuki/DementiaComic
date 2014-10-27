using UnityEngine;
using System.Collections;

public class DC2_comaBehaviour : MonoBehaviour {
	public float moveSpeed = 0.08f;
	public GameObject comaFirst;
	public float comaDif = 7.0f;
	public float bunkiDif = 1.55f;

	private SpriteRenderer coma3SR;
	private SpriteRenderer coma4SR;
	
	//public Sprite coma3Sprite;
	//private SpriteRenderer spriteRenderer;
	
	//int comaNum = 2;
	float comaPos;
	float comaFirstX;
	float comaFirstY;
	float comaFirstZ;
	
	float bunkiPos;
	float bunkiMaruX;
	float bunkiMaruY;
	
	
	//GameObject comaInta;
	GameObject bunkiMaru;
	GameObject age90Sprite;
	GameObject age80Sprite;
	GameObject coma3;
	GameObject coma4;
	//DC1_spriteChange dc1SC;
	
	
	void Start () {

		bunkiMaru = GameObject.Find ("4koma_bMaru");
		age80Sprite = GameObject.Find ("DC2_age_80_");
		age90Sprite = GameObject.Find ("DC2_age_90_");

		coma3 = GameObject.Find ("DC2_03");
		coma4 = GameObject.Find ("DC2_04");

		coma3SR = coma3.GetComponent<SpriteRenderer> ();
		coma4SR = coma4.GetComponent<SpriteRenderer> ();

		comaFirstX = comaFirst.transform.position.x;
		comaFirstY = comaFirst.transform.position.y;
		comaFirstZ = comaFirst.transform.position.z;
		
		bunkiMaruX = bunkiMaru.transform.position.x;
		bunkiMaruY = bunkiMaru.transform.position.y;
		
	}
	
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
		




		if(comaFirst.transform.position.y == 7.0f){
			if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Ended) {
	            Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
	            Vector3 newVector = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	 
	            Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
	            Collider2D colition2d = Physics2D.OverlapPoint(tapPoint);
	 
	            if(colition2d) {
	                RaycastHit2D hitObject = Physics2D.Raycast(tapPoint, -Vector2.up);
					if(hitObject){

						if(hitObject.collider.gameObject.name == "DC2_age_80_"){
							Age80();
						}

						
						if(hitObject.collider.gameObject.name == "DC2_age_90_"){
							Age90();
						}

					}
	            }
	        }
		}

	}
	
	void Age80(){
		age80Sprite.transform.localScale = new Vector3(3,3,3);
		age90Sprite.transform.localScale = new Vector3(2,2,2);
		coma3SR.sprite = Resources.Load<Sprite>("2_Age/DC2_80-03");
		coma4SR.sprite = Resources.Load<Sprite>("2_Age/DC2_80-04");
	}

	
	void Age90(){
		age80Sprite.transform.localScale = new Vector3(2,2,2);
		age90Sprite.transform.localScale = new Vector3(3,3,3);
		coma3SR.sprite = Resources.Load<Sprite>("2_Age/DC2_90-03");
		coma4SR.sprite = Resources.Load<Sprite>("2_Age/DC2_90-04");
	}

}

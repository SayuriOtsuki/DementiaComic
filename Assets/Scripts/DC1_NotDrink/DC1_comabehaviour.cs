using UnityEngine;
using System.Collections;

public class DC1_comaBehaviour : MonoBehaviour {
	public float moveSpeed = 0.08f;
	public GameObject comaFirst;
	public float comaDif = 7.0f;
	public float bunkiDif = 1.55f;
	public Sprite coma3Sprite;
	private SpriteRenderer spriteRenderer;

	int comaNum = 2;
	float comaPos;
	float comaFirstX;
	float comaFirstY;
	float comaFirstZ;

	float bunkiPos;
	float bunkiMaruX;
	float bunkiMaruY;


	GameObject comaInta;
	GameObject bunkiMaru;
	DC1_spriteChange dc1SC;

	
	void Start () {

		comaInta = GameObject.Find ("4komaTest_66_3");
		spriteRenderer = comaInta.GetComponent<SpriteRenderer>();

		bunkiMaru = GameObject.Find ("4koma_bMaru");

		dc1SC = comaInta.GetComponent<DC1_spriteChange> ();

		comaFirstX = comaFirst.transform.position.x;
		comaFirstY = comaFirst.transform.position.y;
		comaFirstZ = comaFirst.transform.position.z;

		bunkiMaruX = bunkiMaru.transform.position.x;
		bunkiMaruY = bunkiMaru.transform.position.y;

	}

	void Update () {

		if(Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Moved){

			//coma3に来て、spriteの変更が終わっていないときだけ動きを止める
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

		//ぴたっと止める
		if(Input.touchCount  ==1 && Input.GetTouch (0).phase == TouchPhase.Ended){

			//1
			if(comaFirst.transform.position.y < 5.0f){
				comaNum = 2;
				if(spriteRenderer.sprite != coma3Sprite){
					spriteRenderer.sprite = Resources.Load<Sprite>("1_NotDrink/DC1_03");
				}
				comaPos = comaDif*0 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);

				bunkiPos = bunkiDif*0 + bunkiMaruX;
				bunkiMaru.transform.position = new Vector3(bunkiPos, bunkiMaruY, 0);
				}

			//2
			if(comaFirst.transform.position.y >= 5.0f && comaFirst.transform.position.y  < 11.3f){
				comaNum = 2;
				if(spriteRenderer.sprite != coma3Sprite){
					spriteRenderer.sprite = Resources.Load<Sprite>("1_NotDrink/DC1_03");
				}
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

		//coma3に来たときだけオブジェクトを検出・sprite変更
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

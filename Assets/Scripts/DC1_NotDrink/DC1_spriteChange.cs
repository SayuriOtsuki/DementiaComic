using UnityEngine;
using System.Collections;

public class DC1_spriteChange : MonoBehaviour {


	private SpriteRenderer spriteRenderer; 
	public Sprite testSprite;

	// Use this for initialization
	void Start () {
	
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1) {
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collition2d  = Physics2D.OverlapPoint(tapPoint);
			
			if (collition2d) {
				RaycastHit2D hitObject = Physics2D.Raycast(tapPoint,-Vector2.up);
				
				if (hitObject) {
					Debug.Log("hit object is " + hitObject.collider.gameObject.name);
					if(hitObject.collider.gameObject.name == "4komaTest_66_3"){
						spriteRenderer.sprite = Resources.Load<Sprite>("1_NotDrink/DC1_04");
						//spriteRenderer.sprite = testSprite;
						//Debug.Log("spriteRenderer is" + spriteRenderer.sprite.name);
					}
				}
			}
		}
	}
}

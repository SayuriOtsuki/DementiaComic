using UnityEngine;
using System.Collections;

public class DC1_spriteChange : MonoBehaviour {

	public GameObject coma3;
	public SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
	
		spriteRenderer = coma3.GetComponent<SpriteRenderer>();
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
						Debug.Log("Hit");
						spriteRenderer.sprite = Resources.Load<Sprite>("DC1_04");
					}
				}
			}
		}
	}
}

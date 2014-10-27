using UnityEngine;
using System.Collections;

public class SelectTouch : MonoBehaviour {

	public GameObject coma1;

	void Update(){
		if ( Input.touchCount == 1) {
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collition2d  = Physics2D.OverlapPoint(tapPoint);
			
			if (collition2d) {
				RaycastHit2D hitObject = Physics2D.Raycast(tapPoint,-Vector2.up);
				
				if (hitObject) {
					Debug.Log("hit object is " + hitObject.collider.gameObject.name);
					if(hitObject.collider.gameObject.name == "4komaTest_66_1"){
						Debug.Log("Hit");
						Destroy(coma1);
					}
				}
			}
		}

	}
}

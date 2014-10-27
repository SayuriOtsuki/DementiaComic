using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

	public float camRayLength = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	/*void Update () {
		if  (Input.touchCount == 1){
			
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			
			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				Debug.Log(obj.name);
			}
		}
	}*/

	 /*if(Input.GetKeyUp(KeyCode.Space)){
		Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
		if(collition2d){
			RaycastHit2D hitObject = Physics2D.Raycast(tapPoint,-Vector2.up);
			if (hitObject) {
				Debug.Log("hit object is " + hitObject.collider.gameObject.name);
			}
		}
	}*/

	void Update(){

		if(Input.GetKeyUp(KeyCode.Space)){
			Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
	
			RaycastHit floorHit;
	
			if(Physics.Raycast (camRay, out floorHit, camRayLength))
			{
				//GameObject obj = floorHit.transform.gameObject;
				Debug.Log("Touch");
			}
		}
	}
}

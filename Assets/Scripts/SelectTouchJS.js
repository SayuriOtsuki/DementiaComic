#pragma strict

public var coma1 : GameObject;

function Start () {

}

function Update () { 
	if (Input.GetKeyUp(KeyCode.Space)) {
    var tapPoint : Vector2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    var collition2d : Collider2D = Physics2D.OverlapPoint(tapPoint);
    	
    	if (collition2d) {
        var hitObject : RaycastHit2D = Physics2D.Raycast(tapPoint,-Vector2.up);
     		
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
using UnityEngine;
using System.Collections;

public class DC1_spriteChange : MonoBehaviour {


	private SpriteRenderer spriteRenderer; 
	public Sprite testSprite;


	// Use this for initialization
	void Start () {
	
		spriteRenderer = GetComponent<SpriteRenderer>();

		if (spriteRenderer.sprite == null) {
			SpriteOne();
		}

	}
	/*void Update () {

	}*/
	
	public void SpriteChangePre(int comaNum) {
		int maxComa = 8;
		Debug.Log ("SpriteChange Pre! comaNum= "+ comaNum);

		if(comaNum <= maxComa){
			SpriteChange(comaNum.ToString());
		}
	}

	void SpriteChange(string comaNum){
		Debug.Log ("SpriteChange");
		spriteRenderer.sprite = Resources.Load<Sprite>("1_NotDrink/DC1_0"+ comaNum);
		//spriteRenderer.sprite = testSprite;
		//Debug.Log("spriteRenderer is" + spriteRenderer.sprite.name);

	}

	void SpriteOne(){
		spriteRenderer.sprite = Resources.Load<Sprite>("1_NotDrink/DC1_03");
	}
	
	
}

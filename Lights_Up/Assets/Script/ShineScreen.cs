using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineScreen : MonoBehaviour {
	[SerializeField] float LightSpeed;
	[SerializeField] float Base;
	SpriteRenderer spriteRenderer;
	float Light_timer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		LightScreen();
	}
	void LightScreen(){
		Color NewColor = new Color(1,1,1,1);
		Light_timer += Time.deltaTime*LightSpeed;

		if(Light_timer <= .5f){
			NewColor *= (Light_timer*(2-2*Base) + Base);
		}
		else{
			NewColor *= (1.0f - Light_timer)*(2-2*Base) + Base;
		}
		
		Light_timer %= 1.0f;
		NewColor.a = 1.0f;

		spriteRenderer.color = NewColor;
	}
	public void SetSpeed(float _Speed){
		LightSpeed= _Speed;
	}
	public void SetBase(float _base){
		Base = _base;
	}
}

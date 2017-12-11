using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Level_ShineScreen : Task_Basic {
	[SerializeField] float LightSpeed;
	[SerializeField] float Base;
	[SerializeField] SpriteRenderer spriteRenderer;
	float Light_timer;

	// Update is called once per frame
	internal override void T_Update () {
		LightScreen();
	}
	public override void OnAbort(){
		OffScreen();
	}
	void OffScreen(){
		spriteRenderer.color = Color.black;
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
}

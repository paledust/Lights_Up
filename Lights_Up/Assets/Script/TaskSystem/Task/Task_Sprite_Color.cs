using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Sprite_Color : Task_Basic {
	[SerializeField] SpriteRenderer m_sprite;
	[SerializeField] Color TargetColor;
	[SerializeField] float WaitTime;
	Color StartColor;
	float timer;

	public override void Init(){
		timer = 0.0f;
		StartColor = m_sprite.color;
	}
	internal override void T_Update(){
		timer += Time.deltaTime/WaitTime;

		m_sprite.color = Color.Lerp(StartColor, TargetColor, timer);

		if(timer >= 1){
			SetStatus(TaskStatus.Success);
		}
	}
}

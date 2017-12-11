using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Level_TextShow : Task_Basic {
	[SerializeField] TextMesh text;
	[SerializeField] float WaitTime;
	[SerializeField] Color TargetColor;
	Color StartColor;
	float timer;
	// Use this for initialization
	public override void Init(){
		StartColor = text.color;
		timer = 0.0f;
	}
	internal override void T_Update(){
		timer += Time.deltaTime/WaitTime;

		text.color = Color.Lerp(StartColor,TargetColor, timer);
		if(timer >= 1){
			SetStatus(TaskStatus.Success);
		}
	}
}

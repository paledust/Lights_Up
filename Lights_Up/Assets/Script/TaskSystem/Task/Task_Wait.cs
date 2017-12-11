using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Wait : Task_Basic {
	[SerializeField] float WaitTime;
	float timer;
	// Use this for initialization
	public override void Init(){
		timer = 0.0f;
	}
	internal override void T_Update(){
		timer += Time.deltaTime;
		if(timer >= WaitTime){
			SetStatus(TaskStatus.Success);
		}
	}
}

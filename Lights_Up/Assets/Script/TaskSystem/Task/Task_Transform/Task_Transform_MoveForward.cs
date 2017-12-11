using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Transform_MoveForward : Task_Basic {
	[SerializeField] Transform TargetTransform;
	[SerializeField] float TravelDistance;
	[SerializeField] float WaitTime;
	float timer;
	Vector3 startPos;
	Vector3 endPos;
	public override void Init(){
		timer = 0.0f;
		startPos = TargetTransform.position;
		endPos = TargetTransform.position + TargetTransform.forward * TravelDistance;
	}
	// Use this for initialization
	internal override void T_Update(){
		timer += Time.deltaTime/WaitTime;

		TargetTransform.position = Vector3.Lerp(startPos, endPos, timer);

		if(timer >= 1.0f){
			SetStatus(TaskStatus.Success);
		}
	}

}

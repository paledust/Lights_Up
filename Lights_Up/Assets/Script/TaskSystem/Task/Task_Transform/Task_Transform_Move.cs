using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Transform_Move : Task_Basic {
	[SerializeField] Transform obj;
	[SerializeField] Transform TargetLocation;
	[SerializeField] float WaitTime;
	Vector3 startPosition;
	float timer;
	public override void Init(){
		timer = 0.0f;
		startPosition = obj.position;
	}
	internal override void T_Update(){
		timer += Time.deltaTime/WaitTime;

		obj.position = Vector3.Lerp(startPosition, TargetLocation.position, timer);

		if(timer >= 1.0f){
			SetStatus(TaskStatus.Success);
		}
	}
	public void SetTarget(Transform _Location){
		TargetLocation = _Location;
	}
}

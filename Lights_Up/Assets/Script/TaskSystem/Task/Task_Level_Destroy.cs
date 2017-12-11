using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Level_Destroy : Task_Basic {
	CreateCar carManager;
	[SerializeField] Transform TargetObj;
	// Use this for initialization
	public override void Init(){
		carManager = FindObjectOfType<CreateCar>();
		SetStatus(TaskStatus.Success);
		carManager.Destroy_A_Car(TargetObj.gameObject);
	}
}

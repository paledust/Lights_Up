using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Ctrl_DisableScript : Task_Basic {

	[SerializeField] MonoBehaviour Script;
	// Use this for initialization
	public override void Init(){
		Script.enabled = false;
		SetStatus(TaskStatus.Success);
	}
}

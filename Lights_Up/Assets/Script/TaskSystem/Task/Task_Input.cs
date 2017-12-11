using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Input : Task_Basic {
	// Update is called once per frame
	internal override void T_Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			SetStatus(TaskStatus.Success);
		}
	}
}

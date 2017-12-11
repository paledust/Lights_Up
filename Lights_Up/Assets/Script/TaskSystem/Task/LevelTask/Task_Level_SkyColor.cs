using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Level_SkyColor : Task_Basic {
	[SerializeField] Color SkyColor;
	// Use this for initialization
	public override void Init () {
		Camera.main.backgroundColor = SkyColor;
		SetStatus(TaskStatus.Success);
	}

}

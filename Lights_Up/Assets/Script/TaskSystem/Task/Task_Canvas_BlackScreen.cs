using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Task_Canvas_BlackScreen : Task_Basic {
	[SerializeField] Image image;
	[SerializeField] bool IF_ON;
	// Use this for initialization
	public override void Init(){
		image.enabled = IF_ON;
		SetStatus(TaskStatus.Success);
	}
}

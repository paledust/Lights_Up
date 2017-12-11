using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Task_Level_LoadLevel : Task_Basic {
	[SerializeField] string levelName;
	// Use this for initialization
	public override void Init(){
		SetStatus(TaskStatus.Success);
		SceneManager.LoadScene(levelName);
	}
}

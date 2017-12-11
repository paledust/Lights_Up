using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Task_Scene_LoadScene : Task_Basic {
	[SerializeField] string LevelName;
	public override void Init(){
		SceneManager.LoadScene("LevelName");
	}
}

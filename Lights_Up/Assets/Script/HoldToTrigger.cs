using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldToTrigger : MonoBehaviour {
	[SerializeField] Task_Basic overTimeTask;
	ShineScreen shineScreen;
	AudioSource audioSource;
	[SerializeField] float OverTime;
	float timer;
	bool Triggered;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		shineScreen = GetComponent<ShineScreen>();
		shineScreen.SetBase(0.0f);
		shineScreen.SetSpeed(0.0f);
		timer = 0.0f;
		Triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			timer += Time.deltaTime;
		}
		else if(timer > 0.0f){
			timer -= Time.deltaTime;
		}
		if(timer < 0.0f){
			timer = 0.0f;
		}
		if(timer > OverTime){
			timer = OverTime;
		}
		
		float _b = Mathf.Lerp(0.0f, .9f, timer/OverTime);
		float _s = Mathf.Lerp(0.0f, 30.0f, timer/OverTime);

		audioSource.volume = .5f*timer/OverTime;
		audioSource.pitch = timer/OverTime;

		shineScreen.SetBase(_b);
		shineScreen.SetSpeed(_s);

		if(timer >= OverTime && !Triggered){
			Triggered = true;
			FindObjectOfType<Task_Manager>().AddTask(overTimeTask);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounting : MonoBehaviour {
	[Header("StartTime should be 24 hours")]
	[SerializeField] string StartTime;
	[SerializeField] TextMesh textMesh;
	public string String_Time{get; protected set;}
	string min_Time;
	string hr_Time;
	float timer;
	const float min = 60;
	// Use this for initialization
	void Start () {
		timer = 30.0f;
		String_Time = StartTime;
		hr_Time = String_Time.Split(':')[0];
		min_Time = String_Time.Split(':')[1];
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime * 5;
		if(timer >= 60){
			AddMin();
			CompleteTime();
			textMesh.text = String_Time;
		}
	}
	protected void AddMin(){
		int min = int.Parse(min_Time);
		min ++;
		if(min == 60){
			min = 0;
			min_Time = "00";
			AddHour();
		}
		else{
			if(min < 10){
				min_Time = "0" + min.ToString();
			}
			else{
				min_Time = min.ToString();
			}
		}
		
	}
	protected void AddHour(){
		int hour = int.Parse(hr_Time);
		hour ++;

		if(hour == 24){
			hour = 0;
			hr_Time = "00";
		}
		else{
			if(hour < 10){
				hr_Time = "0" + hour.ToString();
			}
			else{
				hr_Time = hour.ToString();
			}
		}
	}
	protected void CompleteTime(){
		String_Time = hr_Time + ":" + min_Time;
		String_Time = String_Time;
		timer = 0.0f;
	}
	public void DisableThis(){
		enabled = false;
	}
}

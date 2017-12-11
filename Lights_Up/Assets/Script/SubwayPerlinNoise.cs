using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubwayPerlinNoise : MonoBehaviour {
	[SerializeField] float Seed;
	[SerializeField] float Frequency;
	[SerializeField] float Ampify;
	float timer;
	Vector3 startPoint;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
		startPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime * Frequency;
		float rnd_x = Mathf.PerlinNoise(timer + Seed, 0.0f);
		float rnd_y = Mathf.PerlinNoise(0.0f, timer + .5f + Seed);
		transform.position = startPoint + new Vector3(rnd_x,rnd_y,0).normalized * Ampify;
	}
}

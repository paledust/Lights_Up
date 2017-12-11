using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLight : CreateCar {
	[SerializeField] Transform TargetLocation;
	public override void Create_A_Car(){
		Transform SpawnTrans = Random.Range(0,2)==1?SpawnLocation_1:SpawnLocation_2;
		GameObject car = Instantiate(CarPrefeb, SpawnTrans.position, SpawnTrans.rotation) as GameObject;	
		CarList.Add(car);
		car.GetComponentInChildren<Task_Transform_Move>().SetTarget(TargetLocation);
	}
}

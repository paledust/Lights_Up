using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCar : MonoBehaviour {
	[SerializeField] protected GameObject CarPrefeb;
	[SerializeField] protected Transform SpawnLocation_1;
	[SerializeField] protected Transform SpawnLocation_2;
	[SerializeField] protected List<GameObject> CarList;
	// Use this for initialization
	virtual protected void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(CarList.Count < 4){
			if(Input.GetKeyDown(KeyCode.Space)){
				Create_A_Car();
			}
		}
	}
	public virtual void Create_A_Car(){
		Transform SpawnTrans = Random.Range(0,2)==1?SpawnLocation_1:SpawnLocation_2;
		GameObject car = Instantiate(CarPrefeb, SpawnTrans.position, SpawnTrans.rotation) as GameObject;	
		CarList.Add(car);
	}
	public virtual void Destroy_A_Car(GameObject car){
		CarList.Remove(car);
		Renderer[] Renderers = car.GetComponents<Renderer>();
		foreach(Renderer m_renderer in Renderers){
			m_renderer.enabled = false;
		}
		Destroy(car,1.0f);
	}
}

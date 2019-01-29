using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGenerater : MonoBehaviour {
	public GameObject enemy;
	private int count;
	public bool isRight = false;
	private float time;
	public bool auto = false;
	private bool start = false;
	public float wave = 5f;
	//private int enemylimit;

	// Use this for initialization
	void Start () {
		time = wave;
	}
	
	// Update is called once per frame
	void Update () {
		if(start){
			time += Time.deltaTime;
			//Debug.Log(time);
			if(time >= wave){
				Instantiate(
				enemy,
				transform.position,
				Quaternion.AngleAxis((isRight ? 180 : 0),Vector2.up));
				time = 0;
		}
	}
}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
		if(auto == true){
			start = true;
				
		}else{
			if(count >= 1)return;
			Instantiate(
				enemy,
				transform.position,
				Quaternion.AngleAxis((isRight ? 180 : 0),Vector2.up));
			count += 1;

		}
	}
	}

	void OnDrawGizmos(){
		Vector3 offset = new Vector3(0, 0.5f,0);

		Gizmos.color = new Color(0,1,0,0.5f);
		Gizmos.DrawSphere(transform.position + offset,100);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBakudan : MonoBehaviour {
public GameObject baku;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag != "Boss"){
			Instantiate (
			baku,
			transform.position,
			Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kibako : MonoBehaviour {
	private int KibakoHP = 3;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(KibakoHP <= 0){
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Bakudan"){
			//Destroy(this.gameObject);
			KibakoHP -= 1;
		}
	}
}

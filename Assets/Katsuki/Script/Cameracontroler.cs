using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cameracontroler : MonoBehaviour {
private GameObject player;
//private Rigidbody2D rb2d;
private Vector3 offset;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("N-san");
		//rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3(player.transform.position.x + 500, 5.5f, -15);
		if(transform.position.x >= 17300){
			transform.position = new Vector3(17300, 5.5f, -15);

		}

		if(transform.position.x <= -0){
			transform.position = new Vector3(-0, 5.5f, -15);
		}
	}
}

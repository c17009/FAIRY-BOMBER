using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberControler : MonoBehaviour {
private Rigidbody2D rb2D;
public GameObject baku;
	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) return;
        float v = Input.GetAxis("Vstick");
		float h = Input.GetAxis("Hstick");

		if(h >= 0.9||h <= -0.9||v >= 0.9||v <= -0.9){
			rb2D.AddForce (new Vector2(1000 * h,2000 * v ));
		}

	}

    //爆発エフェクト生成
	void OnCollisionEnter2D(Collision2D other){ 
       if(other.gameObject.tag == "enemy"){
       	Instantiate (
			baku,
			transform.position,
			Quaternion.identity);
       	       	//Debug.Log("k");
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        Bomber.bom = true;
       }else{
       	Destroy(this.gameObject);
       	Instantiate (
			baku,
			transform.position,
			Quaternion.identity);
       	Bomber.bom = true;
       }
    }



   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bomber : MonoBehaviour {
public float Shotpowery = 40000;
public GameObject BomberPrefab;
private float shotpowerx;
public static bool bom = true;
AudioSource audioSource;
public List<AudioClip> audioClip = new List<AudioClip>();
	// Use this for initialization
	void Start () {
		audioSource = gameObject.AddComponent<AudioSource>();
        bom = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) return;
	
	 if (Input.GetButtonDown("Fire1")){
	 	if(bom != true) return;

		GameObject Bomber = (GameObject)Instantiate (
			BomberPrefab,
			transform.position,
			Quaternion.identity);
		audioSource.PlayOneShot(audioClip[0]);
		Rigidbody2D bomb = Bomber.GetComponent<Rigidbody2D> ();
		//bomb.AddForce (new Vector2 (100000,50000));
		if (CharacterControler.isRight){
		shotpowerx = 50000;
        }else{
    	shotpowerx = -50000;
        }
        bomb.AddForce (new Vector2 (shotpowerx, Shotpowery));
        bom = false;
	 }
    
    }
}

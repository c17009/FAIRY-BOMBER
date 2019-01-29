using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBomber : MonoBehaviour {
public float Shotpowery = 40000;
public GameObject bomPrefab;
public GameObject bigbom;
private float shotpowerx;
private float time;
AudioSource audioSource;
public List<AudioClip> audioClip = new List<AudioClip>();
	// Use this for initialization
	void Start () {
		audioSource = gameObject.AddComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) return;
		time += Time.deltaTime;
		if(time >= 3){
			int i = Random.Range(0,2);
			if(i == 0){
				NormalBomber();
			}else if(i == 1){
				StraightBomber();
			}else if(i == 2){
				BigBomber();
			}
			time = 0;
		}
}

void NormalBomber (){
	if(transform.position.x >= 16841&&transform.position.x <= 17752){
	GameObject Bomber = (GameObject)Instantiate (
			bomPrefab,
			transform.position,
			Quaternion.identity);
		audioSource.PlayOneShot(audioClip[0]);
		Rigidbody2D bomb = Bomber.GetComponent<Rigidbody2D> ();
	if (boss.isBossRight){
		shotpowerx = 50000;
        }else{
    	shotpowerx = -50000;
        }
        bomb.AddForce (new Vector2 (shotpowerx, Shotpowery));
    }
}

void StraightBomber(){
	if(transform.position.x >= 16841&&transform.position.x <= 17752){
	GameObject Bomber = (GameObject)Instantiate (
			bomPrefab,
			transform.position,
			Quaternion.identity);
		audioSource.PlayOneShot(audioClip[0]);
		Rigidbody2D bomb = Bomber.GetComponent<Rigidbody2D> ();
	if (boss.isBossRight){
		shotpowerx = 100000;
        }else{
    	shotpowerx = -100000;
        }
        bomb.AddForce (new Vector2 (shotpowerx, Shotpowery));
    }
}

void BigBomber(){
	if(transform.position.x >= 16841&&transform.position.x <= 17752){
	GameObject Bomber = (GameObject)Instantiate (
			bigbom,
			transform.position,
			Quaternion.identity);
		audioSource.PlayOneShot(audioClip[0]);
		Rigidbody2D bomb = Bomber.GetComponent<Rigidbody2D> ();
	if (boss.isBossRight){
		shotpowerx = 10000;
        }else{
    	shotpowerx = -10000;
        }
        bomb.AddForce (new Vector2 (shotpowerx * 2, Shotpowery * 1.3f));
    }
}
}

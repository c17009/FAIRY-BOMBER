using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour {
Rigidbody2D rb2d;
public GameObject BossBom;
public static bool isBossRight = false;
public float left;
public float Right;
public int bossHp = 15;
private float Jtime;
private float time;
private Animator anim;

    // Use this for initialization
    void Start () {
        if (SceneManager.GetActiveScene().name != "stage3") return;
        Gamemaneger.boss = true;
        rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
        //booHP.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) return;
		time += Time.deltaTime;
		Jtime += Time.deltaTime;

		if(time >= 3){
			anim.SetTrigger("Bthrow");
			time = 0;
		}

		if (Jtime >= 5){
			anim.SetTrigger("Jump");
			rb2d.AddForce(new Vector2 (0,50000));
			Jtime = 0;
		}

		if(bossHp <= 0){
            Gamemaneger.bossempty = true;
            Destroy(this.gameObject);
		}
		
		transform.Translate(new Vector2 (-5,0));
		if (transform.position.x <= left){
			isBossRight = true;
		}
		if (transform.position.x >= Right){
			isBossRight = false;
		}
		transform.rotation = Quaternion.AngleAxis((isBossRight ? 180 : 0), Vector3.up);
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Bakudan"){
			bossHp -= 1;
			Debug.Log("atk");
		}
	}
}

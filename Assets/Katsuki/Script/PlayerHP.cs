using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour {
public readonly int maxHP = 100;    //体力の最大値
public int HP;    //体力
public int EnemyATK = 10;　　//敵の攻撃力
private float time;
private GameObject zanki;
	// Use this for initialization
	void Start () {
		zanki = GameObject.Find("zanki");
		HP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0){
        zanki.GetComponent<unitmaneger>().death();
        //this.gameObject.SetActive(false);
        }
	}

	 void OnCollisionEnter2D(Collision2D other){ 

        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "Bossbom"){

            HP -= EnemyATK; //攻撃で体力が減少
            Debug.Log(HP); //HPを表示
        }else if(other.gameObject.tag == "Boss"){
        	HP -= (EnemyATK * 2);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
    	if(other.gameObject.tag == "enemy"){
    		HP -= (EnemyATK / 2)	;
    	}
    }
}

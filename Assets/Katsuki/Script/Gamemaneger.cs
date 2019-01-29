using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Gamemaneger : MonoBehaviour {

public bool pause = false;
public static bool boss = false;
public static bool bossempty = false;
public GameObject Buttons;
public GameObject bossHPbar;
private GameObject timeUI;
private Text gametimeText;
private string gametime;


	void Start () {
		Cursor.visible = false;                            //マウスカーソル消す
		Buttons = GameObject.Find("Buttons");
		if(SceneManager.GetActiveScene().name != "title"){
			Buttons.SetActive(false);
		}
	}
	
	void Update () {
		if(SceneManager.GetActiveScene().name != "title"){ //ポーズの処理
			
		 if (Input.GetButtonDown("Start")){
        	if (pause == false){
        		Time.timeScale = 0;
        		Buttons.SetActive(true);
        		pause = true;
        	}else{
        		Time.timeScale = 1;
        		Buttons.SetActive(false);
        		pause = false;
        	}
        }
    }
        if (boss && SceneManager.GetActiveScene().name == "stage3")
        {
            bossHPbar.SetActive(true);
        }
        if(boss == false)
        {
            bossHPbar.SetActive(false);
        }
}

	public void Gameover(){                      //ゲームオーバー処理
		Buttons.SetActive (true);
				Time.timeScale = 0f;
		}

	public void toGameScene(){                   //シーン遷移
		//audioSource.PlayOneShot(audioClip[0]);
	Debug.Log ("Start!");
	unitmaneger.unit = 3;
	Time.timeScale = 1f;
	SceneManager.LoadScene("stage1");
}

public void title(){
	//audioSource.PlayOneShot(audioClip[0]);
	unitmaneger.stage = 1;
	//Buttons.SetActive(false);
	SceneManager.LoadScene("title");
}

public void retry(){
	//audioSource.PlayOneShot(audioClip[0]);
	int x = unitmaneger.stage;
	//Buttons.SetActive(false);
	unitmaneger.unit = 3;
	Time.timeScale = 1f;
	SceneManager.LoadScene("stage" + x);
}

public void NextStage(){
	unitmaneger.stage += 1;
	int x = unitmaneger.stage;
	SceneManager.LoadScene("stage" + x);
}

public void End(){
	//audioSource.PlayOneShot(audioClip[0]);
	Application.Quit();
}
}


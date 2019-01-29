using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour {

void Update(){
	/*if (Input.GetButtonDown("Start")){
		int x = unitmaneger.stage;
	SceneManager.LoadScene("stage" + x);
	}*/
}

public void toGameScene(){
	Debug.Log ("Start!");
	SceneManager.LoadScene("stage1");
}


}

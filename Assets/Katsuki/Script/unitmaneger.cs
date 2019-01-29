using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class unitmaneger : MonoBehaviour {
public static int unit = 3;
private Text UnitLabel;
private float time;
public static int stage = 1;
private GameObject Gamemaneger;
private GameObject player;
    public GameObject bossHPbar;
	// Use this for initialization
	void Start () {
		UnitLabel = this.gameObject.GetComponent<Text>();
		Gamemaneger = GameObject.Find("Main Camera");
		player = GameObject.Find("N-san");
	}
	
	// Update is called once per frame
	void Update () {
		UnitLabel.text = "x  " + unit;

		if (unit <= 0){
			player.SetActive(false);
			Gamemaneger.GetComponent<Gamemaneger>().Gameover();
		}
	}

	public void death (){
		time += Time.deltaTime;
			if(time >= 3){
				time = 0;
            if(SceneManager.GetActiveScene().name == "stage3")
            {
                bossHPbar.SetActive(false);
            }
				unit -= 1;

			SceneManager.LoadScene("stage" + stage);
			}

	}
}

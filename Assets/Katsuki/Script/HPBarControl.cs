using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPBarControl : MonoBehaviour {
	GameObject player;
    PlayerHP hpcomp;
    Slider hpslider;
    private int hp;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("N-san");　
        hpcomp = player.GetComponent<PlayerHP>();　

        hpslider = GameObject.Find("HPBar").GetComponent<Slider>();
        hp = 100;　// 最大HPの値
        hpslider.value = hp;

	}
	
	// Update is called once per frame
	void Update () {
		int PyHP = hpcomp.HP;　//PlayerHP内の変数HPをPyHPとして使用
        hpslider.value = PyHP;

	}
}

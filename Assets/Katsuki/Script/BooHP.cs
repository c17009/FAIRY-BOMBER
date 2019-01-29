using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BooHP : MonoBehaviour {
    GameObject Boss;
    boss bossc;
    Slider boslider;
    private int BHP;
    // Use this for initialization
    void Start() {
        if (SceneManager.GetActiveScene().name == "stage3") {
            Boss = GameObject.Find("Boss(Clone)");
            bossc = Boss.GetComponent<boss>();

            boslider = GameObject.Find("BossHPbar").GetComponent<Slider>();
            BHP = 150;
            boslider.value = BHP;
        }
    }

        // Update is called once per frame
        void Update() {
        if (SceneManager.GetActiveScene().name == "stage3")
        {
            int BOSSHP = bossc.bossHp;
            boslider.value = BOSSHP;
        }
        }
    }

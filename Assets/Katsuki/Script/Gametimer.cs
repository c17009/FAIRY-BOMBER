using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gametimer : MonoBehaviour {

    public float limitTime = 300;
    float timecount;
    private GameObject zanki;
    // Use this for initialization
    void Start () {
        if (SceneManager.GetActiveScene().name != "title")
        {
            zanki = GameObject.Find("zanki");
            timecount = limitTime;
            GetComponent<Text>().text = ((int)timecount).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) return;
        if (SceneManager.GetActiveScene().name != "title")
        {
            timecount -= Time.deltaTime;
            GetComponent<Text>().text = ((int)timecount).ToString();
            if(timecount<= 1)
            {
                zanki.GetComponent<unitmaneger>().death();
                Gamemaneger.boss = false;
            }
        }
    }
}

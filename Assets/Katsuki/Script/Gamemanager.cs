using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour {
	//ゲームタイム
	float gametime;
	Text timeText;
	int playerNumber;
	Text playerNumberText;
	GameObject buttonsPanel;
	[SerializeField]Slider playerHpBar;

	// Use this for initialization
	void Start () {
		playerHpBar.value = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Damage(float damagePoint)
	{
		playerHpBar.value -= damagePoint;
	}
}

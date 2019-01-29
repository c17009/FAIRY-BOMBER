using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baku : MonoBehaviour {
	AudioSource audioSource;
public List<AudioClip> audioClip = new List<AudioClip>();
private float time = 0;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.PlayOneShot(audioClip[0]);
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time >= 1){
			Destroy(this.gameObject);
		}
		
	}
}

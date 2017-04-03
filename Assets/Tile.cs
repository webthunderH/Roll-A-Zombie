using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public GameManger Gm;
	public AudioClip hit;
	AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Gm.AddPoint();
		source.PlayOneShot(hit);
	}
}

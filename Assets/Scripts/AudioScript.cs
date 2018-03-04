using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
    AudioSource audioSource;
    bool play, toggleChange;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        play = true;
        toggleChange = true;
    }
	
	// Update is called once per frame
	void Update () {
		if (play && toggleChange)
        {
            audioSource.Play();
            toggleChange = false;
        }
	}
}

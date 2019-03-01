using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {
    private float Timer = 9.0f;
    public AudioSource audio;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if (Timer <= 0 && Timer >= -1)
        {
            playAudio();
        }
        if (Timer <= 0&&Timer>=-7.5)
        {         
            transform.Rotate(0,(-12)*Time.deltaTime, 0);
        }
        if (Timer <= -7.5)
        {
            audio.enabled = false;
        }
	}
    void playAudio()
    {
        audio.enabled = true;
    }
}

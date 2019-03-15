﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {
    private bool fly =false;
    private bool land = false;
    private bool ende = false;
    public float speed = 2f;
    public AudioSource audio;
    private bool audioOn = false;
    public Material start;
    public Material second;
    private GameObject lamp;
    public float timer = 5.0f;  

    void Start () {
        lamp =this.gameObject.transform.GetChild(0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        
         if (fly)
         {
            if (this.transform.position.y >= 30)
            {
                fly = false;
                land = true;
            }
            transform.Translate(0, speed * Time.deltaTime, 0);
            //light.intensity=2f;
            lamp.GetComponent<Light>().intensity = 2f;
            
        }
        else if (land)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                lamp.GetComponent<MeshRenderer>().material = start;
                lamp.GetComponent<Light>().intensity = 0f;
                ende = true;
                Ende();
            }
        }
      
        //transform.Rotate(0, spinForce * Time.deltaTime, 0);

    }
    public void ChangeSpin()
    {
        //if (timer2 >= 3)
        //{
            if (!ende)
            {
                if (!audioOn)
                {
                    playAudio();
                    audioOn = true;
                }
                fly = true;
                lamp.GetComponent<MeshRenderer>().material = second;
            }
        //}
    }
    void playAudio()
    {
        audio.enabled = true;
    }
    public void Ende()
    {
        if (ende)
        {
            this.GetComponent<RotateCube>().enabled = false; //wenn Ende erreich wird Skript deaktiviert
        }
    }
    
}
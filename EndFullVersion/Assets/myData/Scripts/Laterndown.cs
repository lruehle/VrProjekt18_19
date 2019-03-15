using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laterndown : MonoBehaviour {
    private bool fly = false;
    private bool ende = false;
    private bool land = false;
    public float speed = -2f; 
    public float timer = 2.0f;
    public float timer2 =0f;
    public Material start;
    public Material second;
    public movePole script; //for access to script
    private GameObject lamp;
    private GameObject post;
    public AudioSource audio;
    private bool audioOn = false;

    void Start()
    {
        post = GameObject.Find("CapsuleB1");
        lamp = this.gameObject.transform.GetChild(0).gameObject;
        script = post.GetComponent<movePole>();
    }

    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
        if (timer2 == 3f)
        {
            godown();
        }
        if (fly)
        {
            if (this.transform.position.y <= 4.5)
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
            timer -= Time.deltaTime; //Lampe geht aus nach timer
            if (timer <= 0)
            {
                lamp.GetComponent<MeshRenderer>().material = start;
                lamp.GetComponent<Light>().intensity = 0f;
                ende = true;
                if (post.transform.position.y <= 6){
                    post.transform.Translate(0, 5, 0);
                    post.transform.Rotate(-90, 0, 0);
                    if (post.transform.position.x <= 32)
                    {
                        post.transform.Translate(1, 0, 0);
                    }
                    script.turn(); 
                }
            }
        }
    }
    public void godown()
    {
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

    }

    void playAudio()
    {
        audio.enabled = true;
    }

}

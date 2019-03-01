using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleLamp : MonoBehaviour {

    private bool fly = false;
    //public float speed = 6f;
    public GameObject door;
    private OpenDoor doorScript;
    public AudioSource audio;
    private bool audioOn = false;
    public Material start;
    public Material second;
    private GameObject lamp;    

    void Start()
    {
        doorScript = door.GetComponent<OpenDoor>();
        lamp = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (fly)
        {
            transform.Rotate(0, 10*Time.deltaTime,0);
            lamp.GetComponent<Light>().intensity = 2f;
        }

        //transform.Rotate(0, spinForce * Time.deltaTime, 0);

    }
    public void ChangeSpin()
    {
            if (!audioOn)
            {
                playAudio();
                audioOn = true;
            }
            doorScript.enabled = true;
            fly = true;
            lamp.GetComponent<MeshRenderer>().material = second;            
    }
    void playAudio()
    {
        audio.enabled = true;
    }
}

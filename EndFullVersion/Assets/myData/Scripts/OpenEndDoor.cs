using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEndDoor : MonoBehaviour {
   // private GameObject Tuer;
    public GameObject Tuer;
    public GameObject InvisibleTuer;
    public GameObject Appear;
    public GameObject Disappear1;
    public GameObject Disappear2;
    public AudioSource OpenAudio;
    public AudioSource CloseAudio;
    public GameObject FloorDisappear;
    private bool sound = false;
    private float go = 0;
    // Use this for initialization
    void Start() {
        //Tuer = this.gameObject.transform.GetChild(0).gameObject;
    }

        // Update is called once per frame
     void Update () {
        if (go == 1)
        {
            openDoor();
        }
	}
    public void openDoor()
    {
        if (!sound)
        {
            OpenAudio.enabled = true;
            sound = true;
        }
        if (Tuer.transform.eulerAngles.y <= 305)
        {
            Tuer.transform.Rotate(0, 10*Time.deltaTime, 0);
            go = 1;
        }
        if (Tuer.transform.eulerAngles.y >= 250 && Tuer.transform.eulerAngles.y <= 305)
        {
            Appear.SetActive(true);
        }      
    }
    public void closeDoor()
    {
        CloseAudio.enabled = true;
        InvisibleTuer.SetActive(true);
        Disappear1.SetActive(false);
        Disappear2.SetActive(false);
        FloorDisappear.SetActive(false);
    }
}

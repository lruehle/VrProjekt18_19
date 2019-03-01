using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLilly : MonoBehaviour {
    private OpenEndDoor Doorscript;
    public GameObject Tuer;
    public AudioSource Audio;
	// Use this for initialization
	void Start () {
        Doorscript = Tuer.GetComponent<OpenEndDoor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            //Debug.Log(other.tag);
            Audio.enabled = true;
            Doorscript.closeDoor();

        }
    }
}

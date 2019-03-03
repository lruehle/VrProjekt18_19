using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBeginn : MonoBehaviour {
    public ChangeScene ChangeScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            ChangeScene.triggerFade1();
        }
    }
}

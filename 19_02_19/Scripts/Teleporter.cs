using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    public Transform destination;
    public ChangeScene ChangeScene;
	// Use this for initialization
	void Start () {
        //destination= GetComponent< Transform>();
        
    }
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            ChangeScene.triggerFade();
           //other.transform.position = destination.position;
            //other.transform.position = new Vector3(-1f,1.5f,2.2f) ;
        }
    }
}

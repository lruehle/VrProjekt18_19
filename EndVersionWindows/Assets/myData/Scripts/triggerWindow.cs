using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWindow : MonoBehaviour {
    public GameObject windowToClose1;
    public GameObject windowToClose2;
    public openWindow scriptToTrigger1;
    public openWindow scriptToTrigger2;
	// Use this for initialization
	void Start () {
        scriptToTrigger1 = windowToClose1.GetComponent<openWindow>();
        scriptToTrigger2 = windowToClose2.GetComponent<openWindow>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerExit(Collider other)
    {
        scriptToTrigger1.close();
        scriptToTrigger2.close();
    }
}

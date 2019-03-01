using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookEnd : MonoBehaviour {
    public ChangeScene ChangeScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void End()
    {
        ChangeScene.triggerFade0();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePole : MonoBehaviour {
    public float spin;
	// Use this for initialization
	void Start () {
        spin = 25f;
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void turn()
    {
        if (this.transform.position.x <= 32)
        {
            transform.Translate(1, 0, 0);
        }
        
    }
}

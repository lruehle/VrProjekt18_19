using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClock : MonoBehaviour {
    public GameObject MinutenZ1;
    public GameObject StundenZ1;
    public GameObject MinutenZ2;
    public GameObject StundenZ2;
    private float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
        MinutenZ1.transform.Rotate(0, 60*Time.deltaTime, 0);
        MinutenZ2.transform.Rotate(0, -60*Time.deltaTime, 0);
        if (timer == 6)
        {
          StundenZ1.transform.Rotate(0, 30 * Time.deltaTime, 0);
          StundenZ2.transform.Rotate(0, -30 * Time.deltaTime, 0);
            timer = 0;
        }
        
	}
}

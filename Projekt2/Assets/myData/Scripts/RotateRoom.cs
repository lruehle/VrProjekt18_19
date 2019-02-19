using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRoom : MonoBehaviour {
    private float timer=0.1f;
    private float z = 0;
    public GameObject Room;
    public GameObject Treppe;
    private bool step = false;
    private float yPos = 0;
	// Use this for initialization
	void Start () {
        yPos = 0.08f;
	}
	
	// Update is called once per frame
	void Update () {
        if (step)
        {
            if (z <= 175)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    if (z <= 170)
                    {
                        Treppe.transform.Rotate(0, 0, 9);
                        Treppe.transform.Translate(0, yPos*Time.deltaTime, 0); //???klappt nicht? :(
                    }
                    else
                    {
                        Treppe.transform.position=new Vector3(22.9f,27.7f,54.1f);
                    }
                    Room.transform.Rotate(0, 0, 5);
                    timer = 0.2f;
                    z += 5;
                }
            }
        }
        
	}
    private void OnTriggerEnter(Collider other)
    {
            step = true;    
    }
}

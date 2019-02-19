using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetheObjectforward : MonoBehaviour {
    public float speed;
    private int direction = 0; //0=forward, 1=backwards	
    public float timer; 
    void Start () {
        speed = 0.06f;
        timer = 37.0f;
    }
	
	// Update is called once per frame
	void Update () {
        Move();
		
	}
    private void Move()
    {

        if (direction == 0)
        {
            Vector3 moveAmount = Vector3.forward * speed * Time.deltaTime;
            transform.Translate(moveAmount);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                direction = 1;
                timer = 37.0f;
            }
        }
        else if (direction == 1)
        {
            Vector3 moveAmount = Vector3.back * speed * Time.deltaTime;
            transform.Translate(moveAmount);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                direction = 0;
                timer = 37.0f;
            }
        }
    }
}

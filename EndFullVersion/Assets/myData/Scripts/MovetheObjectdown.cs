using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetheObjectdown : MonoBehaviour
{
    public float speed;
    private int direction = 0; //0=down, 1=up

    // Use this for initialization
    void Start()
    {
        speed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    private void Move()
    {
        if (direction == 0)
        {
            Vector3 moveAmount = Vector3.down * speed * Time.deltaTime;

            transform.Translate(moveAmount);
            if (this.transform.position.y <= 2.45)
            {
                direction = 1;
            }
        }
        else if (direction == 1)
        {
            Vector3 moveAmount = Vector3.up * speed * Time.deltaTime;

            transform.Translate(moveAmount);
            if (this.transform.position.y >= 2.85)
            {
                direction = 0;
            }
        }
        
    }
}

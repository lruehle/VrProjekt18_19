using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour {

    public GameObject ball;
    public GameObject myHand;
    bool inHands =false;
    Vector3 ballPos;

	// Use this for initialization
	void Start () {
        ballPos = ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                ball.transform.SetParent(myHand.transform);
                ball.transform.localPosition = myHand.transform.localPosition;//oder = newVector3(x,y,z) für genaue Pos
                inHands = true;
            }
            else if (inHands)
            {
                this.GetComponent<PlayerGrab>().enabled = false; // when in hands, PlayerGrab disabled
                ball.transform.SetParent(null);
                ball.transform.localPosition = ballPos;
                inHands = false;
            }
        }
	}
}

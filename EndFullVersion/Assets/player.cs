using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class player : MonoBehaviour {

    public float speed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Move();
	}
    private void Move()
   
    {
        Vector3 moveHorizontal = Input.GetAxis("Horizontal") * Vector3.right * speed;
        Vector3 moveVertical= Input.GetAxis("Vertical") * Vector3.forward * speed;

        Vector3 moveAmount = moveHorizontal + moveVertical;
        this.GetComponent<CharacterController>().SimpleMove(moveAmount);
        
    }
}

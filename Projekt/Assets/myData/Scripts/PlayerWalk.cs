using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerWalk : MonoBehaviour {
    private bool walking = false;
    public int playerSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hit;
        // if (Input.GetButton("Fire1")) // Onclick vs automatisch
        // {
        if(Physics.Raycast(ray, out hit,10.0f))
        {
            //if (hit.collider.name.Contains("Plane")) // wenn auf Boden geschaut wird
            if(hit.collider.gameObject.tag=="Interactive") //bei Lampe nur beim Licht??
            {
                walking = false;
            }
            else
            {
                walking = true;
            }
        }
        if (walking) {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
            //}
	}
}

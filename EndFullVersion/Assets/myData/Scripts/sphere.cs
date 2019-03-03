using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void fall()
    {
        if (transform.position.y > 1)
        {
            transform.Translate(0, -1, 0);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeFall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 1)
        {
            transform.Translate(0, -1, 0);
        }
        
	}
}
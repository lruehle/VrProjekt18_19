using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaterneKlein : MonoBehaviour {
    public GameObject Laterne1;
    public GameObject Laterne2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Laterne1.transform.Rotate(0, 18 * Time.deltaTime, 0);
        Laterne2.transform.Rotate(0, -25 * Time.deltaTime, 0);
    }
}

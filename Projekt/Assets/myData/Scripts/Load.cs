using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour {
    public Transform RadProgress;
    public float myTime=0f;
	// Use this for initialization
	void Start () {
        RadProgress.GetComponent<Image>().fillAmount = myTime;
	}
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;
        RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
	}
    public void Reset()
    {
        myTime = 0f;
        RadProgress.GetComponent<Image>().fillAmount = myTime;
    }
}

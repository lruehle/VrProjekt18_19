using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerWalk : MonoBehaviour {
    //private bool walking = false; //***für automatisches laufen
    public int playerSpeed;
  //  public Load loadscript; ***load
   // public Image loadImage; ***load
	// Use this for initialization
	void Start () {
        //loadscript = loadImage.GetComponent<Load>();
	}
	
	// Update is called once per frame
	void Update () {
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0)); //***für automatisches laufen & load
        //RaycastHit hit; //***für automatisches laufen & load
        if (Input.GetButton("Fire1")) // Onclick vs automatisch
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }



        /*if (Physics.Raycast(ray, out hit, 10.0f)) //**** für automatisches laufen***
        {
            //if (hit.collider.name.Contains("Plane")) // wenn auf Boden geschaut wird
            if (hit.collider.gameObject.tag == "Interactive") //bei Lampe nur beim Licht??
            {
                loadscript.Go();
            }
            else
            {
                loadscript.Reset();
            }
        }*/
            /* if(Physics.Raycast(ray, out hit,10.0f)) //**** für automatisches laufen***
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

             if (walking) {
                 transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
             }}*/
            //}
        }
}

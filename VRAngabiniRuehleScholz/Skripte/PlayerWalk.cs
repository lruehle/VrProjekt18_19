using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerWalk : MonoBehaviour {
    //private bool walking = false; //***für automatisches laufen
    public int playerSpeed;
    public GameObject Player;
    private AudioSource Audio;
    private AudioSource AudioWalk;
    //private bool hasAudio = false;
  //  public Load loadscript; ***load
   // public Image loadImage; ***load
	// Use this for initialization
	void Start () {
        if (this.gameObject.transform.GetChild(1).GetComponent<AudioSource>())
        {       
            AudioWalk = this.gameObject.transform.GetChild(1).GetComponent<AudioSource>();
        }
        /*if (this.gameObject.transform.GetChild(2))
        {
            if (this.gameObject.transform.GetChild(2).GetComponent<AudioSource>())
            {
                Audio = this.gameObject.transform.GetChild(2).GetComponent<AudioSource>();
                hasAudio = true;
            }
        }*/
        //loadscript = loadImage.GetComponent<Load>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1")) // Onclick vs automatisch
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            AudioWalk.enabled = true;
            AudioWalk.volume = Random.Range(0.15f, 0.5f);
            AudioWalk.pitch = Random.Range(0.8f, 1.1f);
        }
        else
        {
           AudioWalk.enabled = false;
        }

      /* if (hasAudio) // Lilly
        {
            timer += Time.deltaTime;
        }
        
        if (timer >= 15)
        {
            Audio.enabled = false;
            Audio.enabled = true;
            timer = 0;
        }*/
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0)); //***für automatisches laufen & load
        //RaycastHit hit; //***für automatisches laufen & load
       



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

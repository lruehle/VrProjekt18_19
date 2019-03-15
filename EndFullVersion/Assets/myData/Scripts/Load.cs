using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour {
    public Transform RadProgress;
    public float myTime;
    public GameObject Lampe1;
    public GameObject Lampe2;
    public GameObject Lampe3;
    public GameObject Lampe4;
    public GameObject Door;
    public GameObject Buch;
    public MeshRenderer MeshRender;
    private string name;

    private RotateCube Lampe1script;
    private LanternUpsideDown Lampe2script;
    private Laterndown Lampe3script;
    private CircleLamp Lampe4script;
    private OpenEndDoor openDoorscript;
    private BookEnd BookEndScript;
    private bool hastriggeredDoor = false;
    private bool hastriggeredBuch = false;
    private bool hastriggered1=false;
    private bool hastriggered2 = false;
    private bool hastriggered3 = false;
    private bool hastriggered4 = false;
    //Camera camera;
    //private Image image;

    // Use this for initialization
    void Start () {
        myTime = 0f;
        RadProgress.GetComponent<Image>().fillAmount = myTime;
        openDoorscript = Door.GetComponent<OpenEndDoor>();
        BookEndScript = Buch.GetComponent<BookEnd>();
        Lampe1script = Lampe1.GetComponent<RotateCube>();
        Lampe2script = Lampe2.GetComponent<LanternUpsideDown>();
        Lampe3script = Lampe3.GetComponent<Laterndown>();
        Lampe4script = Lampe4.GetComponent<CircleLamp>();
       // camera = GetComponent<Camera>();
    }

    private void Update()
    {
        Ray ray2 = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        // Debug.DrawLine(transform.position,(transform.forward * Length));
        myTime += Time.deltaTime;

        if (Physics.Raycast(ray2, out hit)) // sendet Ray aus, der True returned, wenn er ein Objekt trifft (oder Collider dessen?)
        {
            MeshRender.enabled = false;
            name = hit.transform.gameObject.name; // Name dessen, was vom Ray getroffen wird, wird in "name" gespeichert
            if (name == "DoorEnde"||name=="Door"||name=="Door1")
            {
                if (!hastriggeredDoor)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    openDoorscript.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        hastriggeredDoor = true;
                        openDoorscript.openDoor();
                        Debug.Log("Door");
                        Reset();
                    }
                }

            }
            if (name == "LaterneA1" || name == "Lamp1") //"name" wird abgeglichen mit Game-Objektnamen
            {
                if (!hastriggered1) // wenn noch nicht vorher vollendet
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe1script.enabled = true;        // enabled script
                    if (RadProgress.GetComponent<Image>().fillAmount == 1) //wenn der Ladekreis voll geladen ist
                    {
                        hastriggered1 = true; //verhindert erneutes Laden des Ladekreises
                        Lampe1script.ChangeSpin(); // starte function in Skript
                        Debug.Log("A1");
                        Reset();
                    }
                }

            }
             if (name == "LaterneB2" || name == "Lamp2")
            {
                if (!hastriggered2)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe2script.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        hastriggered2 = true;
                        Lampe2script.godown();
                        Debug.Log("B2");
                        Reset();
                    }
                }
            }
             if (name == "LaterneB1" || name == "Lamp3")
            {
                if (!hastriggered3)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe3script.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        hastriggered3 = true;
                        Lampe3script.godown();
                        Debug.Log("B1");
                        Reset();
                    }
                }
            }
            if (name == "LaterneA2" || name == "Lamp4")
            {
                if (!hastriggered4)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe4script.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        hastriggered4 = true;
                        Lampe4script.ChangeSpin();
                        Reset();
                        Debug.Log("A2");
                    }
                }

            }
             if (name == "BuchTrigger")
            {
                if (!hastriggeredBuch)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    BookEndScript.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        hastriggeredBuch = true;
                        BookEndScript.End();
                        Debug.Log("Buch");
                    }
                }
            }
        }
        else
        {
            Reset();
        }
    }
    public void Reset()
    {
        MeshRender.enabled = true;
        myTime = 0f;
        RadProgress.GetComponent<Image>().fillAmount = myTime;
    } // partial props to Julian Klink
}

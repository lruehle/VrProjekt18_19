using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour {
    public Transform RadProgress;
    public float myTime=0f;
    public GameObject Lampe1;
    public GameObject Lampe2;
    public GameObject Lampe3;
    public GameObject Lampe4;
    public string name;

    private RotateCube Lampe1script;
    private LanternUpsideDown Lampe2script;
    private Laterndown Lampe3script;
    private RotateCube Lampe4script;
    private bool hastriggered1=false;
    private bool hastriggered2 = false;
    private bool hastriggered3 = false;
    private bool hastriggered4 = false;
    //Camera camera;
    //private Image image;

    // Use this for initialization
    void Start () {
        RadProgress.GetComponent<Image>().fillAmount = myTime;
        Lampe1script = Lampe1.GetComponent<RotateCube>();
        Lampe2script = Lampe2.GetComponent<LanternUpsideDown>();
        Lampe3script = Lampe3.GetComponent<Laterndown>();
        Lampe4script = Lampe4.GetComponent<RotateCube>();
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
            name = hit.transform.gameObject.name; // Name dessen, was vom Ray getroffen wird, wird in "name" gespeichert
            if (name == "LaterneA1" || name == "Lamp1") //"name" wird abgeglichen mit Game-Objektnamen
            {
                if (!hastriggered1) // wenn noch nicht vorher vollendet
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe1script.enabled = true;        // enabled script
                    if (RadProgress.GetComponent<Image>().fillAmount == 1) //wenn der Ladekreis voll geladen ist
                    {
                        Lampe1script.ChangeSpin(); // starte function in Skript
                        hastriggered1 = true; //verhindert erneutes Laden des Ladekreises

                    }
                }

            }
            else if (name == "LaterneB2" || name == "Lamp2")
            {
                if (!hastriggered2)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe2script.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        Lampe2script.godown();
                        hastriggered2 = true;

                    }
                }
            }
            else if (name == "LaterneB1" || name == "Lamp3")
            {
                if (!hastriggered3)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe3script.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        Lampe3script.godown();
                        hastriggered3 = true;

                    }
                }
            }
            else if (name == "LaterneA2" || name == "Lamp4")
            {
                if (!hastriggered4)
                {
                    RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
                    Lampe4script.enabled = true;
                    if (RadProgress.GetComponent<Image>().fillAmount == 1)
                    {
                        //Lampe4script.enabled = true;
                        Lampe4script.ChangeSpin();
                        hastriggered4 = true;

                    }
                }

            }
        }
    }
    public void Reset()
    {
        myTime = 0f;
        RadProgress.GetComponent<Image>().fillAmount = myTime;
    } // partial props to Julian Klink
}

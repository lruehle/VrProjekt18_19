using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour {

    public ChangeScene ChangeScene;
    public Transform RadProgress;
    public MeshRenderer MeshRender;
    private float myTime = 0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MeshRender.enabled = false;
        myTime += Time.deltaTime;
        RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
        if (RadProgress.GetComponent<Image>().fillAmount == 1)
        {
            ChangeScene.EndGame();

        }
    }
    /* void look()
     {
         RadProgress.GetComponent<Image>().fillAmount = myTime / 3;
         if (RadProgress.GetComponent<Image>().fillAmount == 1)
         {
             ChangeScene.triggerFade(1);

         }
     }*/
    public void Reset()
    {
        MeshRender.enabled = true;
        myTime = 0f;
        RadProgress.GetComponent<Image>().fillAmount = myTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public Animator animator;
    private int level;
    public AudioSource audio;
	// Use this for initialization
	void Start () {
		
	}
    //https://www.youtube.com/watch?v=Oadq-IrOazg // StartCoroutine();

    // Update is called once per frame
    void Update () {
        /*if (Input.GetMouseButtonDown(0))
        {
            FadetoScene(1);
        }*/
	}
    public void triggerFade0()
    {
        FadetoScene(0);
    }
    public void triggerFade1()
    {
            FadetoScene(1);    
    }
    public void triggerFade2()
    {
            FadetoScene(2);    
    }
    public void triggerFade3()
    {
        FadetoScene(3);
    }
    public void triggerFade4()
    {
        FadetoScene(4);
    }

    public void FadetoScene(int levelIndex)
    {
        level = levelIndex;
        audio.enabled = true;
        animator.SetTrigger("FadeOUt");
    }

    public void onFadeComplete()
    {
        SceneManager.LoadScene(level);
    }
    public void EndGame()
    {
        Debug.Log("presssed Exit button");
        Application.Quit();
        
    }
}

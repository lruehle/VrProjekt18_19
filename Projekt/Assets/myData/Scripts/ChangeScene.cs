using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public Animator animator;
    private int level;
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
    public void triggerFade()
    {
            FadetoScene(1);    
    }

    public void FadetoScene(int levelIndex)
    {
        level = levelIndex;
        animator.SetTrigger("FadeOUt");
    }

    public void onFadeComplete()
    {
        SceneManager.LoadScene(level);
    }
}

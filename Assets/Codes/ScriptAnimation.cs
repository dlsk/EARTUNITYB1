using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimation : MonoBehaviour {

    private float targetTimeAnimationLaunch = 2.0f;
    private float currentTime = 0.0f;
    public GameObject animPont;
    public GameObject animBouton;
    public Animator animationPont;
    public GameObject BoutonBoolen;

    private void Awake()
    {
        animationPont = animPont.GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
        animationPont.speed = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {

        if (BoutonBoolen.GetComponent<AnimationBouton>().animationPassée == true)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= 1.5f)
            {
                animationPont.speed = 1.0f;
                currentTime = targetTimeAnimationLaunch;
            }
        }
    }
}

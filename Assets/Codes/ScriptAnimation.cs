using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimation : MonoBehaviour {

    public float timeAnimationAtLaunch = 0.0f;
    public float currentTime = 0.0f;
    private bool soundOn = false;
    public GameObject animPont;
    public GameObject animBouton;
    public Animator animationPont;
    public GameObject BoutonBoolen;

    private void Awake()
    {
        animationPont = animPont.GetComponent<Animator>();
    }
    
    void Start () {
        animationPont.speed = 0.0f;
    }
	
	void Update () {

        if (BoutonBoolen.GetComponent<AnimationBouton>().animationPassée == true)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= 0.7f)
            {
                soundOn = !soundOn;
                animationPont.speed = 1.0f;
                animBouton.GetComponent<AnimationBouton>().animationBouton.speed = 0.0f;
                //currentTime = timeAnimationAtLaunch;
            }
        }

        if (soundOn == true)
        {
            VoiceActivation.Instance.MakeSonPont();
            soundOn = !soundOn;
        }
    }
}

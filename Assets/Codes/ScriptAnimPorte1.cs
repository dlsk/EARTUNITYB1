using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimPorte1 : MonoBehaviour
{

    public float timeAnimationAtLaunch = 0.0f;
    public float currentTime = 0.0f;
    private bool soundOn = false;
    private bool timerOn = true;
    public GameObject animPorte1;
    public GameObject animBouton;
    public Animator animationPorte1;
    public GameObject BoutonBoolen;

    private void Awake()
    {
        animationPorte1 = animPorte1.GetComponent<Animator>();
    }

    void Start()
    {
        animationPorte1.speed = 0.0f;
    }

    void Update()
    {

        if (BoutonBoolen.GetComponent<AnimationBouton>().animationPassée == true)
        {
            if (timerOn == true)
            {
                currentTime += Time.deltaTime;
            }

            if (currentTime >= 0.7f)
            {
                animationPorte1.speed = 1.0f;
                animBouton.GetComponent<AnimationBouton>().animationBouton.speed = 0.0f;
            }

            /* if (currentTime >= 0.7f)
             {
                 VoiceActivation.Instance.MakeSonPont();
                 soundOn = !soundOn;
                 timerOn = !timerOn;
                 currentTime = timeAnimationAtLaunch;
             }
         }

         if (soundOn == true)
         {
             VoiceActivation.Instance.MakeSonPont();
             //Debug.Log("BUUUUUG");
             soundOn = !soundOn;
         } */
        }
    }
}

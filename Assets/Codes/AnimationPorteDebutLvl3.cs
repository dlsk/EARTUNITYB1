using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPorteDebutLvl3 : MonoBehaviour
{

    public GameObject Porte;
    public Animator animationPorte;
    public static AnimationBouton Instance;


    void Awake()
    {
        animationPorte = Porte.GetComponent<Animator>();
    }

    void Start()
    {
        animationPorte.speed = 1.0f;
        //AnimationPortePlay();
    }

    /*public void AnimationPortePlay()
    {
        animationPorte.speed = 1.0f;
    }*/
}
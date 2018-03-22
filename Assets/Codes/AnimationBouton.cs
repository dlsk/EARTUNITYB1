using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBouton : MonoBehaviour {

    public GameObject animBouton;
    public Animator animationBouton;
    public bool animationPassée = false;
    public static AnimationBouton Instance;


    void Awake()
    {
        animationBouton = animBouton.GetComponent<Animator>();
    }
    
    void Start () {
        animationBouton.speed = 0.0f;
    }

    public void AnimationBoutonPlay()
    {
        animationBouton.speed = 2.0f;
        animationPassée = !animationPassée;
    }
}

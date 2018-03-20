using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBouton : MonoBehaviour {

    public GameObject animBouton;
    public Animator animationBouton;
    public bool animationPassée = false;


    void Awake()
    {
        animationBouton = animBouton.GetComponent<Animator>();
    }
    
    void Start () {
        animationBouton.speed = 0.0f;
    }

    public void AnimationBoutonPlay()
    {
        animationBouton.speed = 1.0f;
        animationPassée = !animationPassée;
    }
}

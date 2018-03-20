using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBouton : MonoBehaviour {

    public GameObject animBouton;
    public Animator animationBouton;
    public bool animationPassée = false;


    private void Awake()
    {
        animationBouton = animBouton.GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
        animationBouton.speed = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void AnimationBoutonPlay()
    {
        animationBouton.speed = 1.0f;
        animationPassée = !animationPassée;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBouton : MonoBehaviour {

    public GameObject BoutonAnim;
    private bool testTriggerBouton = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && testTriggerBouton == true)
        {
            BoutonAnim.GetComponent<AnimationBouton>().AnimationBoutonPlay();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            testTriggerBouton = !testTriggerBouton;
        }
    }
}

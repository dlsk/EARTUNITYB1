using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBouton : MonoBehaviour {

    public GameObject BoutonAnim;
    public GameObject PlayerCamera;
    public GameObject PlayerModel;
    public GameObject Fantome;
    public GameObject TriggerFantome;
    private float _registerFantomeTime;
    private Vector3 fantomePosition;
    private bool testTriggerBouton;
    private bool onOrOff = true;

	// Use this for initialization
	void Start () {
        testTriggerBouton = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (_registerFantomeTime >= TriggerFantome.GetComponent<TriggerTimeFantome>().triggerTimer && onOrOff == true)
        {
            Apparition();
            onOrOff = !onOrOff;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && testTriggerBouton == true)
        {
            _registerFantomeTime = PlayerCamera.GetComponent<Timer>().targetTime;
            fantomePosition = PlayerModel.transform.position;
            BoutonAnim.GetComponent<AnimationBouton>().AnimationBoutonPlay();
            testTriggerBouton = !testTriggerBouton;
        }
    }

    public void Apparition()
    {
        Fantome.transform.position = fantomePosition;
    }
}

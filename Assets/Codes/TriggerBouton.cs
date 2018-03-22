using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBouton : MonoBehaviour {
    
    public GameObject PlayerCamera;
    public GameObject PlayerModel;
    public GameObject Fantome;
    public GameObject TriggerFantome;
    public GameObject BoutonAnim;
    private float _registerFantomeTimeBouton;
    private float currentTime;
    private Vector3 fantomePosition;
    private bool testTriggerBouton;
    private bool onOrOff = true;

	// Use this for initialization
	void Start () {
        testTriggerBouton = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (_registerFantomeTimeBouton >= TriggerFantome.GetComponent<TriggerTimeFantome>().triggerTimer && onOrOff == true)
        {
            Apparition();
            onOrOff = !onOrOff;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && testTriggerBouton == true)
        {
            Debug.Log("Appuis");
            _registerFantomeTimeBouton = PlayerCamera.GetComponent<Timer>().targetTime;
            fantomePosition = PlayerModel.transform.position;
            BoutonAnim.GetComponent<AnimationBouton>().AnimationBoutonPlay();
            testTriggerBouton = !testTriggerBouton;
            //Pont.GetComponent<ScriptAnimation>().currentTime = Pont.GetComponent<ScriptAnimation>().timeAnimationAtLaunch;
            VoiceActivation.Instance.MakeSoundTrois();
        }
    }

    public void Apparition()
    {
        Fantome.transform.position = fantomePosition;
    }
}

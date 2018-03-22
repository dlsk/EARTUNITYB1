using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBoutonAnimLvL3 : MonoBehaviour
{

    public GameObject PlayerCamera;
    public GameObject PlayerModel;
    public GameObject TriggerFantome;
    public GameObject BoutonAnim;
    private float _registerFantomeTimeBouton;
    private float currentTime;
    private bool testTriggerBouton;
    private bool onOrOff = true;
    public bool animationOn = false;

    // Use this for initialization
    void Start()
    {
        testTriggerBouton = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_registerFantomeTimeBouton >= TriggerFantome.GetComponent<TriggerTimeFantome>().triggerTimer && onOrOff == true)
        {
            onOrOff = !onOrOff;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && testTriggerBouton == true)
        {
            Debug.Log("Appuis");
            _registerFantomeTimeBouton = PlayerCamera.GetComponent<Timer>().targetTime;
            BoutonAnim.GetComponent<AnimationBouton>().AnimationBoutonPlay();
            testTriggerBouton = !testTriggerBouton;
        }
    }

}

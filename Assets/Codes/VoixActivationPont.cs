using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoixActivationPont : MonoBehaviour {

    public bool voixOn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (voixOn == true)
        {
            VoiceActivation.Instance.MakeSoundTrois();
            voixOn = !voixOn;
        }
	}
}

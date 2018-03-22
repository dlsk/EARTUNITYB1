using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour {

    public GameObject MurInvisible;
    public GameObject PlayerModel;
    public GameObject MurPositionInitial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MurInvisible.transform.position = PlayerModel.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MurInvisible.transform.position = MurPositionInitial.transform.position;
        }
    }
}

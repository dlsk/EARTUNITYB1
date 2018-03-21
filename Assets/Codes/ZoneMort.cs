using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneMort : MonoBehaviour
{
    public GameObject player;
    public GameObject obj1;
    public GameObject obj2;

    void OnTriggerEnter(Collider player)
    {
        Application.LoadLevel(Application.loadedLevel);
        Destroy(obj1, 0.0f);
        Destroy(obj2, 0.0f);
    }
}

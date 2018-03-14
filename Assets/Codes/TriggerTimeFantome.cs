using UnityEngine;

public class TriggerTimeFantome : MonoBehaviour {

    public GameObject PlayerCamera;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Ok c'est bon");
            Debug.Log(PlayerCamera.GetComponent<Timer>().targetTime);
        }
    }
}

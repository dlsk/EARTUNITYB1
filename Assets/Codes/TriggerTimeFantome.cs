using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTimeFantome : MonoBehaviour {

    public GameObject PlayerCamera;
    private float _registerFantomeTime;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Ok c'est bon");
            _registerFantomeTime = PlayerCamera.GetComponent<Timer>().targetTime;
            Debug.Log(_registerFantomeTime);
        }
    }
}

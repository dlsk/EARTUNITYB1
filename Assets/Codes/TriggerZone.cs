using UnityEngine;
using EZCameraShake;
using UnityEngine.SceneManagement;

public class TriggerZone : MonoBehaviour
{
    public float timeLeft = 2.0f;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Oui c'est dedans");
            CameraShaker.Instance.ShakeOnce(15f, 15f, 5f, 5f);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Toujours");
            timeAfterTrigger();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //SceneManager.LoadScene("Cours Script");
            Debug.Log("C'est bien dehors");
        }
    }

    public void timeAfterTrigger()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0.0f)
        {
            SceneManager.LoadScene("scene_lvl2");
        }
    }
}

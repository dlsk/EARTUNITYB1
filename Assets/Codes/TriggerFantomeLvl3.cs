using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class TriggerFantomeLvl3 : MonoBehaviour
{

    public float triggerTimer;
    private bool onOrOff = true;
    private bool testPositionTaken = true;
    public bool Restart = false;
    public string GameScene;
    public GameObject destroyPlayer;
    public GameObject destroyController;
    public GameObject Porte;
    private float _registerFantomeTime;
    private float _registered;
    private Vector3 fantomePosition;
    public GameObject PlayerCamera;
    public GameObject Fantome;
    public GameObject PlayerModel;

    private void Start()
    {
        triggerTimer = 3 * PlayerCamera.GetComponent<Timer>().timeInScene;
        //Debug.Log(triggerTimer);
    }

    private void Update()
    {
        triggerTimer -= Time.deltaTime;

        if (_registerFantomeTime >= triggerTimer && onOrOff == true)
        {
            Apparition();
            onOrOff = !onOrOff;
        }

        if (triggerTimer <= 0)
        {
            Restart = !Restart;
            SceneManager.LoadScene(GameScene);
            Destroy(destroyPlayer, 0.0f);
            Destroy(destroyController, 0.0f);
        }

        if (triggerTimer <= 120.0f)
        {
            //Porte.GetComponent<AnimationPorteDebutLvl3>().AnimationPortePlay();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && testPositionTaken == true)
        {
            //Debug.Log("Ok c'est bon");
            _registerFantomeTime = PlayerCamera.GetComponent<Timer>().targetTime;
            fantomePosition = PlayerModel.transform.position;
            testPositionTaken = !testPositionTaken;
            //Debug.Log(_registerFantomeTime);
        }
    }

    public void Apparition()
    {
        Fantome.transform.position = fantomePosition;
    }
}

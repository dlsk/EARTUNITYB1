using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class TriggerTimeFantome : MonoBehaviour {

    public float triggerTimer;
    private bool onOrOff = true;
    private bool testPositionTaken = true;
    public string GameScene;
    public GameObject destroyobj1;
    public GameObject destroyobj2;
    private float _registerFantomeTime;
    private float _registered;
    private Vector3 fantomePosition;
    public GameObject PlayerCamera;
    public GameObject Fantome;
    public GameObject PlayerModel;
    //private Rigidbody _rigidbody;

    private void Start()
    {
        //_rigidbody = GetComponent<Rigidbody>();
        //Assert.IsNotNull(_rigidbody);
        triggerTimer = 2 * PlayerCamera.GetComponent<Timer>().timeInScene;
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
            SceneManager.LoadScene(GameScene);
            Destroy(destroyobj1, 0.0f);
            Destroy(destroyobj2, 0.0f);
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

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class TriggerTimeFantome : MonoBehaviour {

    public float triggerTimer = 0.0f;
    private bool onOrOff = true;
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
    }

    private void Update()
    {
        triggerTimer -= Time.deltaTime;

        if (_registerFantomeTime >= triggerTimer && onOrOff == true)
        {
            Apparition();
            onOrOff = false;
            Debug.Log("C'est print");
        }

        if (triggerTimer <= 0)
        {
            SceneManager.LoadScene("scene_lvl1");
            Destroy(destroyobj1, 0.0f);
            Destroy(destroyobj2, 0.0f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Ok c'est bon");
            _registerFantomeTime = PlayerCamera.GetComponent<Timer>().targetTime;
            fantomePosition = PlayerModel.transform.position;
            Debug.Log(_registerFantomeTime);
        }
    }

    public void Apparition()
    {
        Fantome.transform.position = fantomePosition;
    }
}

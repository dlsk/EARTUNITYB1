/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ApparitionFantome : MonoBehaviour {
    
    public float speedApparition = 10.0f;
    //private float _timeInScene;
    private float _registeredTime;
    private bool _testTime = false;
    //private Vector3 _hidePosition;
    private Rigidbody _rigidbody;
    public GameObject PlayerCamera;
    public GameObject TriggerFantome;
    //public GameObject Fantome;

    // Use this for initialization
    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
        Assert.IsNotNull(_rigidbody);
        //_timeInScene = PlayerCamera.GetComponent<Timer>().timeInScene;
    }
	
	// Update is called once per frame
	void Update () {
        if (_registeredTime == PlayerCamera.GetComponent<Timer>().targetTime)
        {
            TestTimeFantome();
        }

		if (_testTime == true)
        {
            Apparition();
        }

        //_registeredTime = (TriggerFantome.GetComponent<TriggerTimeFantome>()._registerFantomeTime) - 10;
    }

    private void TestTimeFantome()
    {
        _testTime = true;
    }

    public void Apparition()
    {
        Vector3 newPosition = _rigidbody.transform.position + speedApparition * transform.up * Time.deltaTime;
        _rigidbody.MovePosition(newPosition);
    }
}
*/
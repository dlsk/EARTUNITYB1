using UnityEngine;

public class Timer : MonoBehaviour
{
    public float targetTime = 10.0f;
    public float timeInScene = 10.0f;
    public GameObject PlayerObject;
    public GameObject TargetSpawnRestartAfterTimeout;

    void Update ()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Debug.Log("Fin");
            PlayerSpawnPosition();
            targetTime = timeInScene;
        }
    }

    public void PlayerSpawnPosition()
    {
        PlayerObject.transform.position = TargetSpawnRestartAfterTimeout.transform.position;
        PlayerObject.transform.rotation = TargetSpawnRestartAfterTimeout.transform.rotation;
    }

    protected void OnGUI()
    {
        GUI.Box(new Rect(10, 40, 40, 20), targetTime.ToString("0"));
    }
}

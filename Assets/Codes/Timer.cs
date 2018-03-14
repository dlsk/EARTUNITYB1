using UnityEngine;

public class Timer : MonoBehaviour {

    public float targetTime = 10.0f;
    public float timeInScene = 10.0f;
    
	void Update () {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Debug.Log("Fin");
            targetTime = timeInScene;
            //SceneManager.LoadScene("Test FPS");
        }
    }

    protected void OnGUI()
    {
        GUI.Box(new Rect(100, 10, 40, 20), targetTime.ToString("0"));
    }
}

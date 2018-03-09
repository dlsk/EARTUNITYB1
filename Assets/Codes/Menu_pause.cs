using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_pause : MonoBehaviour
{
    public GameObject panelPause;
    private bool isActive = false;


    void Update()
    {
        //menu affiché
        if (isActive == true)
        {
            panelPause.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0;
        }

        else
        {
            panelPause.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ResumeButton();
        }
    }
   
    public void ResumeButton()
    {
        isActive = !isActive;
    }
}

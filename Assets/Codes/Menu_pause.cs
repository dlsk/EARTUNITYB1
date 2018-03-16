using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_pause : MonoBehaviour
{
    public GameObject panelPause;
    private bool isActive = false;
    private bool index = false;
    public string MenuScene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ResumeButton();
        }

        //menu affiché
        if (isActive == true)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                ChoicesButton();
            }

            if (index == false)
            {               
                if (Input.GetKeyDown(KeyCode.P))
                {
                    ResumeButton();
                }
            }

            if (index == true)
            {
                if (Input.GetKeyDown(KeyCode.P))
                {
                    OnclickMenu();
                }
            }
        }
        else
        {
            panelPause.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ResumeButton()
    {
        isActive = !isActive;
    }

    public void OnclickMenu()
    {
        SceneManager.LoadScene(MenuScene);

    }

    private void ChoicesButton()
    {
        index = !index;

        if (index == false)
            Debug.Log("Resume");

        if (index == true)
            Debug.Log("Menu");
    }
}

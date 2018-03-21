﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_pause : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject panelCommande;
    private bool isActive = false;
    public string GameScene;
    public string MenuScene;
    public GameObject destroyobj1;
    public GameObject destroyobj2;

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
    }

    public void ResumeButton()
    {
        isActive = !isActive;
    }

    public void OnclickRestart()
    {
        SceneManager.LoadScene(GameScene);
        Destroy(destroyobj1, 0.0f);
        Destroy(destroyobj2, 0.0f);
    }

    public void OnclickMenu()
    {
        SceneManager.LoadScene(MenuScene);
        Destroy(destroyobj1,0.0f);
        Destroy(destroyobj2, 0.0f);
    }

    public void ManetteOn()
    {
        panelCommande.SetActive(true);
    }

    public void ManetteOff()
    {
        panelCommande.SetActive(false);
    }
}

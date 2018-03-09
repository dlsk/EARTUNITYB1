using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_principal : MonoBehaviour
{
    public string MenuScene;
    public string PlayScene;
    public string Option_controleScene;
    public string Option_volumeScene;
    public string Option_creditsScene;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Onclickplay()
    {        
        SceneManager.LoadScene(PlayScene);
    }

    public void Onclickoption()
    {
        SceneManager.LoadScene(Option_controleScene);
    }

    public void Onclickorder()
    {
        SceneManager.LoadScene(Option_controleScene);
    }

    public void Onclicksound()
    {
        SceneManager.LoadScene(Option_volumeScene);
    }

    public void Onclickcredits()
    {
        SceneManager.LoadScene(Option_creditsScene);
    }

    public void Onclickquit()
    {
        Application.Quit();
    }

    public void Onclickmenu ()
    {

        SceneManager.LoadScene(MenuScene);
    }

    public void Onclickreturn()
    {
        SceneManager.LoadScene(MenuScene);
    }
}
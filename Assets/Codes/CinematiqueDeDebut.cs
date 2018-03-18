using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CinematiqueDeDebut : MonoBehaviour
{

    public string[] MonTexte;
    public Text ZoneDeTexte;
    private int _textId = 0;
    private int _phraseId = 0;

    // Use this for initialization
    void Start()
    {
        Debug.Log(MonTexte.Length);
        ZoneDeTexte.text = "";
        DisplayLetter();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && (_textId != MonTexte[_phraseId].Length))  //Le && c'est pour que tout s'affiche
        {
            DisplayFullPhrase();
        }
        else if (Input.GetKeyDown(KeyCode.Return) && (_textId == MonTexte[_phraseId].Length))  //Le && c'est pour pas passer si la phrase est pas fini de s'afficher
        {
            NextPhrase();
        }
    }

    public void DisplayLetter()
    {
        if (_textId <= MonTexte[_phraseId].Length - 1)
        {
            ZoneDeTexte.text += MonTexte[_phraseId][_textId].ToString();
            StartCoroutine("TextWait");
        }
    }

    private void DisplayFullPhrase()
    {
        StopCoroutine("TextWait");
        _textId = MonTexte[_phraseId].Length;
        ZoneDeTexte.text = MonTexte[_phraseId];
    }

    IEnumerator TextWait()
    {
        yield return new WaitForSeconds(0.1f);
        _textId++;
        DisplayLetter();
    }

    private void NextPhrase()
    {
        _phraseId++;
        if (_phraseId <= MonTexte.Length - 1)
        {
            _textId = 0;
            ZoneDeTexte.text = "";           //Il faut laisser la dernière case du tableau _phraseId
            DisplayLetter();
        }
    }
}

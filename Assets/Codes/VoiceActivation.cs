﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Création d'effets sonores en toute simplicité
/// </summary>
public class VoiceActivation : MonoBehaviour
{

    /// <summary>
    /// Singleton
    /// </summary>
    public static VoiceActivation Instance;

    public AudioClip SonPont;
    public AudioClip SonBouton;
    public AudioClip Un;
    public AudioClip Deux;
    public AudioClip Trois;
    public AudioClip PortalSound;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of VoiceActivation!");
        }
        Instance = this;
    }

    public void MakeSonPont()
    {
        MakeSound(SonPont);
    }

    public void MakeSoundUn()
    {
        MakeSound(Un);
    }

    public void MakeSoundDex()
    {
        MakeSound(Deux);
    }

    public void MakeSoundTrois()
    {
        MakeSound(Trois);
    }

    public void MakePortalSound()
    {
        MakeSound(PortalSound);
    }

    /// <summary>
    /// Lance la lecture d'un son
    /// </summary>
    /// <param name="originalClip"></param>
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
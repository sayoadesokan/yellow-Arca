﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutemanager : MonoBehaviour
{
    private bool isMuted;
    void Start()
    {
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;
    }

    public void mutepressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
    }
}

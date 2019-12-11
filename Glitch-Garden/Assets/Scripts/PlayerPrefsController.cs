﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{

    // all caps bcuz its how you write for const
    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME   = 0f;
    const float MAX_VOLUME = 1f;


    // static bcuz wont change. want to be consistent throughtout entire game
    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            Debug.Log("Master volume set to" + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    }


    public static float GetMasterVolume()
    {

        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);

    }







}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Setting
{
    //Audio Settings

    public static float MasterVolume
    {
        get
        {
            return PlayerPrefs.GetFloat("MasterVolume", 0.5f);
        }
        set
        {
            PlayerPrefs.SetFloat("MasterVolume", value);
        }
    }
    public static float DialogueVolume
    {
        get
        {
            return PlayerPrefs.GetFloat("DialogueVolume", 0.5f);
        }
        set
        {
            PlayerPrefs.SetFloat("DialogueVolume", value);
        }
    }

    public static float SFXVolume
    {
        get
        {
            return PlayerPrefs.GetFloat("SFXVolume", 0.5f);
        }
        set
        {
            PlayerPrefs.SetFloat("SFXVolume", value);
        }
    }
    public static float MusicVolume
    {
        get
        {
            return PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        }
        set
        {
            PlayerPrefs.SetFloat("MusicVolume", value);
        }
    }

    // Graphics settings
    public static int ResolutionIndex
    {
        get
        {
            return PlayerPrefs.GetInt("ResolutionIndex", 8);
        }
        set
        {
            PlayerPrefs.SetInt("ResolutionIndex", value);
        }
    }
    public static int isFpsLimited
    {
        get
        {
            return PlayerPrefs.GetInt("FPSLimit", Screen.currentResolution.refreshRate);
        }
        set
        {
            PlayerPrefs.SetInt("FPSLimit", value);
        }
    }

    public static int FPSLimit
    {
        get
        {
            return PlayerPrefs.GetInt("FPSLimit", Screen.currentResolution.refreshRate);
        }
        set
        {
            PlayerPrefs.SetInt("FPSLimit", value);
        }
    }
    public static int FullScreen
    {
        get
        {
            return PlayerPrefs.GetInt("FullScreen", 1);
        }
        set
        {
            PlayerPrefs.SetInt("FullScreen", value);
        }
    }

    public static int VSync
    {
        get
        {
            return PlayerPrefs.GetInt("VSync", 1);
        }
        set
        {
            PlayerPrefs.SetInt("VSync", value);
        }
    }

    public static int AA
    {
        get
        {
            return PlayerPrefs.GetInt("AA", 0);
        }
        set
        {
            PlayerPrefs.SetInt("AA", value);
        }
    }
    public static bool Initialized
    {
        get
        {
            return PlayerPrefs.GetInt("Initialized", 0) != 0;
        }
        set
        {
            PlayerPrefs.SetInt("Initialized", value ? 1 : 0);
        }
    }
}
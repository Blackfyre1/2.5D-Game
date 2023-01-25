using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXVolumeChange : MonoBehaviour
{
    public void OnButton(float value)
    {
        Setting.SFXVolume = value;
        Debug.Log(Setting.SFXVolume);
    }
}

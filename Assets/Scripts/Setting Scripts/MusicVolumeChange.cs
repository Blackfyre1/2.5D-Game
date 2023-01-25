using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolumeChange : MonoBehaviour
{
    public void OnButton(float value)
    {
        Setting.MusicVolume = value;
        Debug.Log(Setting.MusicVolume);
    }
}

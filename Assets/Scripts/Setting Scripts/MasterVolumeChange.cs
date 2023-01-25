using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolumeChange : MonoBehaviour
{
    public void OnButton(float value)
    {
        Setting.MasterVolume = value;
        Debug.Log(Setting.MasterVolume);
    }
}

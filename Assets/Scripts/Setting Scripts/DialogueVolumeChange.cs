using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueVolumeChange : MonoBehaviour
{
    public void OnButton(float value)
    {
        Setting.DialogueVolume = value;
        Debug.Log(Setting.DialogueVolume);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class SetFPSLimit : MonoBehaviour
{
    [SerializeField]
    ApplyGraphicChanges AGC;
    [SerializeField]
    GameObject LimitUI;
    Text FPS;

    /*private void Start()
    {
        if (PlayerPrefs.GetInt("isFpsLimited") == 1)
        {
            FPS.text = "" + (PlayerPrefs.GetInt("FPSLimit"));
        }
        else LimitUI.SetActive(false);
    }
    */
    public void ChangeFPSLimit(int Limit)
    {
        AGC.FPSLimit = Limit;
        AGC.Changed = true;
    }
}

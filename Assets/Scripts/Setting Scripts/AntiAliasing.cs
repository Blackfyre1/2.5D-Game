using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class AntiAliasing : MonoBehaviour
{
    [SerializeField]
    ApplyGraphicChanges AGC;
    [SerializeField]
    Dropdown AAUI;
    private int index;

    public void Awake()
    {
        index = PlayerPrefs.GetInt("AA");
        List<Dropdown.OptionData> OptionList = new List<Dropdown.OptionData>();
        for (int i = 0; i < 4; i++)
        {
            Dropdown.OptionData OD = new Dropdown.OptionData("1");
            OptionList.Add(OD);
        }
        AAUI.value = index;
        AAUI.AddOptions(OptionList);
        AAUI.RefreshShownValue();
    }
    public void ChangeAA(int index)
    {
        AGC.AA = index;
        AGC.Changed = true;
    }
}

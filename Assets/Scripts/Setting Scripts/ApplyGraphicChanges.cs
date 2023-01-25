using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyGraphicChanges : MonoBehaviour
{
    public Resolution Resolution;
    public bool Changed;
    public int FPSLimit;
    public int ResolutionIndex;
    public int FullScreen;
    public int VSync;
    public bool isFpsLimited;
    public int AA;
    [SerializeField]
    SettingManager SM;
    void Awake()
    {
        int index = PlayerPrefs.GetInt("ResolutionIndex");
        Resolution = Screen.resolutions[index];
        Changed = false;
        FPSLimit = PlayerPrefs.GetInt("FPSLimit");
        FullScreen = PlayerPrefs.GetInt("FullScreen");
    }

    // Update is called once per frame
    void Apply()
    {
        if(Changed)
        {
            PlayerPrefs.SetInt("ResolutionIndex", ResolutionIndex);
            if (isFpsLimited)
            {
                PlayerPrefs.SetInt("isFpsLimited", 1);
                PlayerPrefs.SetInt("FPSLimit", FPSLimit);
            }
            else
            {
                PlayerPrefs.SetInt("isFpsLimited", 0);
            }
            if (FullScreen == 1)
            {
                PlayerPrefs.SetInt("FullScreen", 1);
            }
            else
            {
                PlayerPrefs.SetInt("FullScreen", 0);
            }
                PlayerPrefs.SetInt("VSync", VSync);
        }
        SM.LoadSettings();
    }
    
}

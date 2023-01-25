using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    private int Initialized;
    // Start is called before the first frame update
    void Start()
    {
        Initialized = PlayerPrefs.GetInt("Initialized");
        if (Initialized == 0)
        {
            PlayerPrefs.SetInt("Initialized",1);
            Resolution R = Screen.currentResolution;
            Resolution[] ResList = Screen.resolutions;
            int index = 0;
            for(int i = 0;i < ResList.Length;i++)
            {
                if (R.width == ResList[i].width && R.height == ResList[i].height) { index = i; break;}
            }
            PlayerPrefs.SetInt("ResolutionIndex", index);
            PlayerPrefs.SetInt("isFpsLimited", 0);
            PlayerPrefs.SetInt("FpsLimit", R.refreshRate);
            PlayerPrefs.SetInt("FullScreen", 1);
            PlayerPrefs.SetInt("VSync", 1);
            PlayerPrefs.SetInt("AA", 3);
            LoadSettings();
        }
    }
    public void LoadSettings()
    {
        Resolution[] ResList = Screen.resolutions;
        Resolution R = ResList[PlayerPrefs.GetInt("ResolutionIndex")];
        if(PlayerPrefs.GetInt("isFpsLimited") == 1)
        {
            Application.targetFrameRate = PlayerPrefs.GetInt("FpsLimit");
        }
        else
        {
            Application.targetFrameRate = int.MaxValue;
        }
        QualitySettings.vSyncCount = PlayerPrefs.GetInt("VSync");
        QualitySettings.antiAliasing = PlayerPrefs.GetInt("AA");
        Screen.SetResolution(R.width, R.height, (PlayerPrefs.GetInt("FullScreen") != 0));
    }
}

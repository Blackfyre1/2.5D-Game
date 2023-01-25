using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VSync : MonoBehaviour
{
    [SerializeField]
    ApplyGraphicChanges AGC;
    private int Vsync;
    [SerializeField]
    GameObject LimitUI;
    // Start is called before the first frame update
    void Awake()
    {
        Vsync = PlayerPrefs.GetInt("VSync");
    }

    // Update is called once per frame
    public void OnButton()
    {
        if (Vsync == 1)
        {
            Vsync = 0;
        }
        else
        {
            Vsync = 1;
        }
        AGC.Changed = true;
        AGC.VSync = Vsync;
        /*if (isFpsLimited)
        {
            LimitUI.SetActive(true);
        }
        else
        {
            LimitUI.SetActive(false);
        }
        */
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isFullScreen: MonoBehaviour
{
    [SerializeField]
    ApplyGraphicChanges AGC;
    private int FullScreen;
    [SerializeField]
    GameObject LimitUI;
    // Start is called before the first frame update
    void Awake()
    {
        FullScreen = PlayerPrefs.GetInt("FullScreen");
    }

    // Update is called once per frame
    public void OnButton()
    {
        if (FullScreen == 1)
        {
            FullScreen= 0;
        }
        else
        {
            FullScreen = 1;
        }
        AGC.Changed = true;
        AGC.FullScreen = FullScreen;
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

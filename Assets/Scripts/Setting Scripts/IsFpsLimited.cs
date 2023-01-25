using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsFpsLimited : MonoBehaviour
{
    [SerializeField]
    ApplyGraphicChanges AGC;
    private int FPSLimit;
    private bool isFpsLimited;
    [SerializeField]
    GameObject LimitUI;
    // Start is called before the first frame update
    void Awake()
    {
        if (PlayerPrefs.GetInt("IsFpsLimited") == 1)
        {
            isFpsLimited = true;
        }
        else
        {
            isFpsLimited = false;
        }
    }

    // Update is called once per frame
    public void OnButton()
    {
        AGC.Changed = true;
        isFpsLimited = !isFpsLimited;
        AGC.isFpsLimited = isFpsLimited;
        if(isFpsLimited)
        {
            LimitUI.SetActive(true);
        }
        else
        {
            LimitUI.SetActive(false);
        }
    }
}

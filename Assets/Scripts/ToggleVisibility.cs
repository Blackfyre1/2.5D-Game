using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Off;
    [SerializeField]
    private List<GameObject> On;
    public void OnButton()
    {
        for (int i = 0; i < Off.Count; i++)
        {
                Off[i].SetActive(false);
        }
        for (int i = 0; i < On.Count; i++)
        {
                On[i].SetActive(true);
        }
    }
}

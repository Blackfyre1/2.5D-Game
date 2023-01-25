using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SetResolution : MonoBehaviour
{
    [SerializeField]
    private Dropdown ResListUI;
    [SerializeField]
    ApplyGraphicChanges AGC;
    private Resolution []ResList;
    private int index = 0;
    private Resolution R;
    // Start is called before the first frame update

    private void Awake()
    {
        ResList = Screen.resolutions;
        index = PlayerPrefs.GetInt("ResolutionIndex");
        List<Dropdown.OptionData> OptionList = new List<Dropdown.OptionData>();
        for (int i = 0; i < ResList.Length; i++)
        {
            Dropdown.OptionData OD = new Dropdown.OptionData((ResList[i].width + " x " + ResList[i].height));
            OptionList.Add(OD);
        }
        ResListUI.value = index;
        ResListUI.AddOptions(OptionList);
        ResListUI.RefreshShownValue();
    }
    public void ChangeResolution(int index)
    {
        AGC.Resolution.height = ResList[index].height;
        AGC.Resolution.width = ResList[index].width;
        AGC.ResolutionIndex = index;
        AGC.Changed = true;
    }
}

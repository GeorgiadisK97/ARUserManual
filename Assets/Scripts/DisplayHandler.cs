using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHandler : MonoBehaviour
{
    private SwitchSelectorScript _var3;


    public void DisplayOn()
    {
        _var3.canvas.SetActive(true);
        _var3.raspberry.SetActive(true); 
        for (int i = 0; i < _var3.switchesList.Length; i++)
            _var3.switchesList[i].SetActive(true);
        if (_var3.step >= 6)
        {
            _var3.charger.SetActive(true);
        }
    }
    public void DisplayOff()
    {
        _var3.canvas.SetActive(false);
        _var3.raspberry.SetActive(false);
        _var3.charger.SetActive(false);       
        for (int i = 0; i < _var3.switchesList.Length; i++)
            _var3.switchesList[i].SetActive(false);
    }

    void Start()
    {
        _var3 = GameObject.Find("SwitchSelectorScript").GetComponent<SwitchSelectorScript>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRoutine : MonoBehaviour
{
    private SwitchSelectorScript _var4;

    public void RoutineWrap()
    {
        if (_var4.dropdown.value == 1)
        {
            if (_var4.step == 1)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay1());
            }
            else if (_var4.step == 2)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay2());
            }
            else if (_var4.step == 3)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay3());
            }
            else if (_var4.step == 4)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay4());
            }
            else if (_var4.step == 5)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay5());
            }
            else if (_var4.step == 6)
            {
                _var4.switchesTags[4].enabled = false;
                _var4.nextButton.interactable = false;
                _var4.pass = true;
                StartCoroutine(_var4.Delay6());
            }
        }
        if (_var4.dropdown.value == 2)
        {
            if (_var4.step == 0)
                _var4.switchesTags[0].enabled = false;
            else if (_var4.step == 1)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay1());
            }
            else if (_var4.step == 2)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay2());
            }
            else if (_var4.step == 3)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay3());
            }
            else if (_var4.step == 4)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay4());
            }
            else if (_var4.step == 5)
            {
                _var4.nextButton.interactable = false;
                StartCoroutine(_var4.Delay5());
            }
            else if (_var4.step == 6)
            {
                _var4.switchesTags[4].enabled = false;
                _var4.nextButton.interactable = false;
                _var4.pass = false;
                StartCoroutine(_var4.Delay6());
            }
        }
        if (_var4.state == "OFF" && _var4.step <= 6 && _var4.step > 0)
            _var4.step--;
        else if (_var4.state == "ON" && _var4.step <= 6)
            _var4.step++;
    }

    void Start()
    {
        _var4 = GameObject.Find("SwitchSelectorScript").GetComponent<SwitchSelectorScript>();
    }

    void Update()
    {
        if (_var4.dropdown.value == 0)
            _var4.nextButton.interactable = false;
        else if (_var4.dropdown.value == 1 && _var4.isDone == true)
        {
            _var4.step++;
            _var4.nextButton.interactable = true;
            _var4.isDone = false;
            _var4.state = "ON";
        }
        else if (_var4.dropdown.value == 2 && _var4.isDone == false && _var4.step > 0)
        {
            _var4.step--;
            _var4.nextButton.interactable = true;
            _var4.isDone = true;
            _var4.state = "OFF";
        }
    }
}

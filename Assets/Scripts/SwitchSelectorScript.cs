using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwitchSelectorScript : MonoBehaviour
{
    public int step;
    public string state = "ON";
    public TextMeshPro text;
    public TextMeshPro[] switchesTags;
    public bool pass = true, isDone = true;
    public Dropdown dropdown;
    public Button nextButton;
    public GameObject raspberry, canvas, charger;
    public GameObject[] switchesList;
    readonly List<Animator> animatorList = new List<Animator>();

    void Start()
    {
        text.enabled = false;
        canvas.SetActive(false);
        charger.SetActive(false);
        raspberry.SetActive(false);
        nextButton.enabled = true;
        step = 0;

        /*.
          Add switches as objects to array `switchesList`.
        */

        if (switchesList.Length >= 1 && switchesTags.Length >= 1)   //Condition of NOT NULL
        {
            for (int i = 0; i < switchesList.Length; i++)
            {
                Debug.Log(switchesList[i]);
                animatorList.Add(switchesList[i].GetComponent<Animator>()); //Add switches animations to list `animatorList`.
                animatorList[i].enabled = false;
                switchesList[i].SetActive(false);
                switchesTags[i].enabled = false;
            }
        }
        else
            return;
    }

    public IEnumerator Delay1()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Switch1");    
        nextButton.interactable = true;
    }
    public IEnumerator Delay2()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Switch2"); 
        nextButton.interactable = true;
    }
    public IEnumerator Delay3()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Switch3");     
        nextButton.interactable = true;
    }
    public IEnumerator Delay4()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Switch4");    
        nextButton.interactable = true;
    }
    public IEnumerator Delay5()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("DoubleSwitch");
        nextButton.interactable = true;
    }
    public IEnumerator Delay6()
    {
        yield return new WaitForSeconds(0.5f);
        charger.SetActive(pass);
        nextButton.interactable = true;
    }
    public IEnumerator InfoRoutine()
    {
        yield return new WaitForSeconds(5f);
    }
    public int SendStep(int a)
    {
        return a;
    }
    public void FindSwitch(string switchName)
    {
        if (switchesList.Length >= 1)
        {
            for (int i = 0; i < switchesList.Length; i++)
            {
                if (switchesList[i].name == switchName)
                {
                    animatorList[i].enabled = true;
                    animatorList[i].SetTrigger(state);
                    switchesTags[i].enabled = true;
                }
                else
                    switchesTags[i].enabled = false;
            }
        }
        else
        {
            return;
        }
    }
}



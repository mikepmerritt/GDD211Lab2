using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonProperties : MonoBehaviour
{
    [SerializeField] private int CorrectValue;
    [SerializeField] private int State;
    [SerializeField] private Image ButtonImg;

    public void Start()
    {
        State = 0;
    }

    public void ToggleButton()
    {
        State = (State + 1) % 5;
        if(State == 1)
        {
            ButtonImg.color = Color.red;
        }
        else if (State == 2)
        {
            ButtonImg.color = Color.yellow;
        }
        else if (State == 3)
        {
            ButtonImg.color = Color.blue;
        }
        else if (State == 4)
        {
            ButtonImg.color = Color.green;
        }
        else
        {
            ButtonImg.color = Color.white;
        }
    }

    public bool CheckCorrectValue()
    {
        return CorrectValue == State;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Camera PlayerCamera;
    [SerializeField] private GameObject PicturePanel, Door, DoorButton;
    [SerializeField] private Image Popup;
    [SerializeField] private Sprite ButtonMap, Key1, Key2, Win;
    [SerializeField] private ButtonProperties[] Buttons;
    [SerializeField] private Material Finish;

    public void RotateCamera(float newAngle)
    {
        PlayerCamera.transform.eulerAngles = new Vector3(0, newAngle, 0);
    }

    public void PrintDebugText()
    {
        Debug.Log("Button Pressed!");
    }

    public void ClosePicture()
    {
        PicturePanel.SetActive(false);
    }

    public void LoadButtonMap()
    {
        Popup.sprite = ButtonMap;
        Popup.preserveAspect = true;
        PicturePanel.SetActive(true);
    }

    public void LoadKey1()
    {
        Popup.sprite = Key1;
        Popup.preserveAspect = true;
        PicturePanel.SetActive(true);
    }

    public void LoadKey2()
    {
        Popup.sprite = Key2;
        Popup.preserveAspect = true;
        PicturePanel.SetActive(true);
    }

    public void CheckButtons()
    {
        bool pass = true;
        foreach(ButtonProperties button in Buttons)
        {
            if(!button.CheckCorrectValue())
            {
                pass = false;
                return;
            }
        }

        if(pass)
        {
            Door.GetComponent<MeshRenderer>().material = Finish;
            DoorButton.SetActive(true);
        }
    }

    public void ExitRoom()
    {
        Popup.sprite = Win;
        Popup.preserveAspect = true;
        PicturePanel.SetActive(true);
    }
}

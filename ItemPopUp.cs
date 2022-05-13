using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPopUp : MonoBehaviour
{
    public Canvas canvas;
    public bool a = false; 
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false);
    }

    public void PopUp(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}

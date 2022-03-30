using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleImage : MonoBehaviour
{
    public GameObject toActivate;
    public ButtonTest buttonTest;

    public bool isActive;

    private void Start()
    {
        toActivate.SetActive(false);
    }

    public void ToggleOnOf()
    {
        if (!isActive && buttonTest.lifeCounter > 1)
        {
            StartCoroutine(buttonTest.LoseLife());
            toActivate.SetActive(true);
            isActive = true;
        }
        else if (isActive)
        {
            toActivate.SetActive(false);
            isActive = false;
        }
    }

    public void Leave()
    {
        Application.Quit();
    }
}

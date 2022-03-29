using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject toActivate;

    public bool isActive;

    private void Start()
    {
        toActivate.SetActive(false);
    }

    public void ToggleOnOf()
    {
        if (!isActive)
        {
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

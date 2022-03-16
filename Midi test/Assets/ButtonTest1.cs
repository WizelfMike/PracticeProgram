using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest1 : MonoBehaviour
{
    bool prompActive;
    string chosenKey;

    Renderer render;

    string[] test = { "a", "b" };

    void Start()
    {
        prompActive = false;
        chooseRandomKey();
        render.enabled = false;

    }

    private void Update()
    {
        
    }

    public void chooseRandomKey()
    {
        if (prompActive == false)
        {
            prompActive = true;
            render.enabled = true;
            chosenKey = test[Random.Range(0, test.Length)];
            Debug.Log(chosenKey);
        }
    }

    void checkCorrect(string keyInput)
    {
        if (keyInput == chosenKey)
        {
            Debug.Log("Correct");
            //Code voor goede code
            render.enabled = false;
            prompActive = false;
            chooseRandomKey();
        }
        if (keyInput != chosenKey)
        {
            Debug.Log("Incorrect");
            //Code voor verkeerde toets
            render.enabled = false;
            prompActive = false;
            chooseRandomKey();
        }
        else
        {
            Debug.Log("Fout?");
            //Foutcode?
            render.enabled = false;
            prompActive = false;
            chooseRandomKey();
        }
    }
}

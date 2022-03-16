using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    bool prompActive;
    string chosenKey;

    public Renderer render;

    string[] test = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

    void Start()
    {
        prompActive = false;
        chooseRandomKey();
        render = GetComponent<Renderer>();
        //render.enabled = false;
    }

    private void Update()
    {

    }

    private void chooseRandomKey()
    {
        if (prompActive == false)
        {
            prompActive = true;
            //render.enabled = true;
            chosenKey = test[Random.Range(0, test.Length)];
            Debug.Log(chosenKey);
        }
    }

    public void checkCorrect(string keyInput)
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

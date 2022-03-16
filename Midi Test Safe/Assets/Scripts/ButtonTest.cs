using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    bool prompActive;
    string chosenKey;

    public Renderer render;

    string[] test = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

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

    public IEnumerator checkCorrect(string keyInput)
    {
        if (keyInput == chosenKey)
        {
            Debug.Log("Correct");
            //Code voor goede code
            render.enabled = false;
            prompActive = false;
            yield return new WaitForSeconds(2);
            chooseRandomKey();
        }
        else if (keyInput != chosenKey)
        {
            Debug.Log("Incorrect");
            //Code voor verkeerde toets
            render.enabled = false;
            prompActive = false;
            yield return new WaitForSeconds(2);
            chooseRandomKey();
        }
        else
        {
            Debug.Log("Fout?");
            //Foutcode?
            render.enabled = false;
            prompActive = false;
            yield return new WaitForSeconds(2);
            chooseRandomKey();
        }
    }
}

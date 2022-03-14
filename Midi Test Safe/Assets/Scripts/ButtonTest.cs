using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    bool prompActive = false;

    string[] test = { "a", "b" };

    string[] randomButton = { "a", "aSharp", "b", "c", "cSharp", "d", "dSharp", "e", "f", "fSharp", "g", "gSharp" };

    void Start()
    {
        this.gameObject.SetActive(false);
        //startTest();
        testFunc();
    }

    void testFunc()
    {
        this.gameObject.SetActive(true);

        int keyPicked = Random.Range(0, test.Length);
        Debug.Log(test[keyPicked]);
        switch (test[keyPicked])
        {
            case "a":
                if (Input.GetKeyDown("a"))
                {
                    this.gameObject.SetActive(false);
                }
                else
                {
                    Debug.Log("Wrong Key pressed");
                }
                break;
            case "b":
                if (Input.GetKeyDown("b"))
                {
                    this.gameObject.SetActive(false);
                }
                else
                {
                    Debug.Log("Wrong Key pressed");
                }
                break;
        }
    }

    void startTest()
    {
        if (prompActive == false)
        {
            prompActive = true;
            int keyPicked = Random.Range(0, randomButton.Length);
            switch (randomButton[keyPicked])
            {
                case "a":
                    break;
            }
        }
        else
        {
            prompActive = false;
            startTest();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class ButtonTest : MonoBehaviour
{
    bool prompActive;
    bool keyPressed;
    string chosenKey;
    int pointCounter;
    int lifeCounter;

    public Renderer render;
    public TextMeshProUGUI keyText;
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI lifeText;

    public string winScene;

    string[] test = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    void Start()
    {
        pointCounter = 0;
        lifeCounter = 3;
        keyPressed = false;
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
            keyText.SetText(chosenKey);
            Debug.Log(chosenKey);
        }
    }

    public IEnumerator RestartGame()
    {
        keyText.SetText("Restarting...");
        yield return new WaitForSeconds(1);
        pointCounter = 0;
        lifeCounter = 3;
        pointText.SetText("Points: " + pointCounter);
        lifeText.SetText("Lives: " + lifeCounter);
        chooseRandomKey();
    }

    public IEnumerator checkCorrect(string keyInput)
    {
        if (keyPressed == false)
        {
            keyPressed = true;
            if (keyInput == chosenKey)
            {
                //Code voor goede code
                prompActive = false;
                pointCounter += 1;
                keyText.SetText("Correct!");
                pointText.SetText("Points: " + pointCounter);
                yield return new WaitForSeconds(2);
                if(pointCounter >= 10)
                {
                    SceneManager.LoadScene(winScene);
                }
                else
                {
                    chooseRandomKey();                
                }
            }
            else if (keyInput != chosenKey)
            {
                //Code voor verkeerde toets
                keyText.SetText("Incorrect!");
                prompActive = false;
                yield return new WaitForSeconds(2);
                if(lifeCounter > 1)
                {
                    lifeCounter -= 1;
                    lifeText.SetText("Lives: " + lifeCounter);
                    chooseRandomKey();
                }
                else
                {
                    lifeCounter -= 1;
                    lifeText.SetText("Lives: " + lifeCounter);
                    keyText.SetText("Out of lives!");
                    yield return new WaitForSeconds(3);
                    StartCoroutine(RestartGame());
                }
            
            }
            else
            {
                Debug.Log("Fout?");
                //Foutcode?
                prompActive = false;
                yield return new WaitForSeconds(2);
                chooseRandomKey();
            }
            keyPressed = false;
        }
    }
}

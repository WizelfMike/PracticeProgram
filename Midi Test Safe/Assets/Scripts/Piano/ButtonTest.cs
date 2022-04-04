using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ButtonTest : MonoBehaviour
{
    public bool prompActive;
    public int lifeCounter;
    string chosenKey;
    int pointCounter;

    public TextMeshProUGUI keyText;
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI lifeText;

    public string winScene;

    string[] test = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    void Start()
    {
        pointCounter = 0;
        lifeCounter = 3;
        prompActive = false;
        chooseRandomKey();
    }

    public void UpdateUI()
    {
        pointText.SetText("Points: " + pointCounter);
        lifeText.SetText("Lives: " + lifeCounter);
    }

    public IEnumerator LoseLife()
    {
        if (lifeCounter > 1)
        {
            lifeCounter -= 1;
            UpdateUI();
            chooseRandomKey();
        }
        else
        {
            lifeCounter -= 1;
            UpdateUI();
            keyText.SetText("Out of lives!");
            yield return new WaitForSeconds(3);
            StartCoroutine(RestartGame());
        }
    }

    private void chooseRandomKey()
    {
        if (!prompActive)
        {
            prompActive = true;
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
        prompActive = false;
        UpdateUI();
        chooseRandomKey();
    }

    public IEnumerator checkCorrect(string keyInput)
    {
        if (keyInput == chosenKey)
        {
            //Code voor goede toets
            pointCounter += 1;
            keyText.SetText("Correct!");
            UpdateUI();
            prompActive = false;
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
            StartCoroutine(LoseLife());
        }
        else
        {
            Debug.Log("Fout?");
            //Foutcode?
            prompActive = false;
            yield return new WaitForSeconds(2);
            chooseRandomKey();
        }
    }
}

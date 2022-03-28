using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public string mainGame;

    public void ClickGame()
    {
        SceneManager.LoadScene(mainGame);
    }
}

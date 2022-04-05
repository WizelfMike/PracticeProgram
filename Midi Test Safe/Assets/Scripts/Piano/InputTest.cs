using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputTest : MonoBehaviour
{
    public Midi pianoController;
    string activeScene;

    [SerializeField] private ButtonTest pressButton;
    [SerializeField] private FreePlayScript freeButton;
    [SerializeField] private ToggleImage activeSheet;

    private void Awake()
    {
        activeScene = SceneManager.GetActiveScene().name;
        pressButton = GetComponent<ButtonTest>();
        /*activeSheet = GetComponent<ToggleImage>();*/
        pianoController = new Midi();
        pianoController.Enable();
    }

    private void Update()
    {

    }

    public void onC(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("C"));
                    Debug.Log("C note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("C");
                    Debug.Log("C note has been hit");
                }
                break;
        }

    }

    public void onCSharp(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("C#"));
                    Debug.Log("C# note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("C#");
                    Debug.Log("C# note has been hit");
                }
                break;
        }
    }

    public void onD(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("D"));
                    Debug.Log("D note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("D");
                    Debug.Log("D note has been hit");
                }
                break;
        }
    }

    public void onDSharp(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("D#"));
                    Debug.Log("D# note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("D#");
                    Debug.Log("D# note has been hit");
                }
                break;
        }
    }

    public void onE(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("E"));
                    Debug.Log("E note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("E");
                    Debug.Log("E note has been hit");
                }
                break;
        }
    }

    public void onF(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("F"));
                    Debug.Log("F note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("F");
                    Debug.Log("F note has been hit");
                }
                break;
        }
    }

    public void onFSharp(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("F#"));
                    Debug.Log("F# note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("F#");
                    Debug.Log("F# note has been hit");
                }
                break;
        }
    }

    public void onG(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("G"));
                    Debug.Log("G note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("G");
                    Debug.Log("G note has been hit");
                }
                break;
        }
    }

    public void onGSharp(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("G#"));
                    Debug.Log("G# note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("G#");
                    Debug.Log("G# note has been hit");
                }
                break;
        }
    }

    public void onA(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("A"));
                    Debug.Log("A note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("A");
                    Debug.Log("A note has been hit");
                }
                break;
        }
    }

    public void onASharp(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("A#"));
                    Debug.Log("A# note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("A#");
                    Debug.Log("A# note has been hit");
                }
                break;
        }
    }

    public void onB(InputAction.CallbackContext context)
    {
        switch (activeScene)
        {
            case "Quiz":
                if (context.performed && !activeSheet.isActive && pressButton.prompActive)
                {
                    StartCoroutine(pressButton.checkCorrect("B"));
                    Debug.Log("B note has been hit");
                }
                break;
            case "FreePlay":
                if (context.performed)
                {
                    freeButton.PlayKey("B");
                    Debug.Log("B note has been hit");
                }
                break;
        }
    }

    private void OnEnable()
    {
        pianoController.Enable();
    }

    private void OnDisable()
    {
        pianoController.Disable();
    }

}

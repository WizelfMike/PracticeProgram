using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    public Midi pianoController;
    [SerializeField] private ButtonTest pressButton;
    [SerializeField] private ToggleImage activeSheet;

    private void Awake()
    {
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
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("C"));
            Debug.Log("C note has been hit");
        }
    }

    public void onCSharp(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("C#"));
            Debug.Log("C# note has been hit");
        }
    }

    public void onD(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("D"));
            Debug.Log("D note has been hit");
        }
    }

    public void onDSharp(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("D#"));
            Debug.Log("D# note has been hit");
        }
    }

    public void onE(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("E"));
            Debug.Log("E note has been hit");
        }
    }

    public void onF(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("F"));
            Debug.Log("F note has been hit");
        }
    }

    public void onFSharp(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("F#"));
            Debug.Log("F# note has been hit");
        }
    }

    public void onG(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("G"));
            Debug.Log("G note has been hit");
        }
    }

    public void onGSharp(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("G#"));
            Debug.Log("G# note has been hit");
        }
    }

    public void onA(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("A"));
            Debug.Log("A note has been hit");
        }
    }

    public void onASharp(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("A#"));
            Debug.Log("A# note has been hit");
        }
    }

    public void onB(InputAction.CallbackContext context)
    {
        if (context.performed && activeSheet.isActive == false)
        {
            StartCoroutine(pressButton.checkCorrect("B"));
            Debug.Log("B note has been hit");
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

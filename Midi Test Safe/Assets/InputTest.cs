using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{

    public Midi pianoController;

    private void Awake()
    {
        pianoController = new Midi();
        pianoController.Enable();
    }

    private void Update()
    {

    }

    public void onC(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("C note has been hit");
        }
    }

    public void onCSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("C# note has been hit");
        }
    }

    public void onD(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("D note has been hit");
        }
    }

    public void onDSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("D# note has been hit");
        }
    }

    public void onE(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("E note has been hit");
        }
    }

    public void onF(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("F note has been hit");
        }
    }

    public void onFSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("F# note has been hit");
        }
    }

    public void onG(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("G note has been hit");
        }
    }

    public void onGSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("G# note has been hit");
        }
    }

    public void onA(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("A note has been hit");
        }
    }

    public void onASharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("A# note has been hit");
        }
    }

    public void onB(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    public AudioSource piano;
    public AudioClip Cnote;
    public AudioClip CSnote;
    public AudioClip Dnote;
    public AudioClip DSnote;
    public AudioClip Enote;
    public AudioClip Fnote;
    public AudioClip FSnote;
    public AudioClip Gnote;
    public AudioClip GSnote;
    public AudioClip Anote;
    public AudioClip ASnote;
    public AudioClip Bnote;


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
            piano.PlayOneShot(Cnote);
        }
    }

    public void onCSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("C# note has been hit");
            piano.PlayOneShot(CSnote);
        }
    }

    public void onD(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("D note has been hit");
            piano.PlayOneShot(Dnote);
        }
    }

    public void onDSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("D# note has been hit");
            piano.PlayOneShot(DSnote);
        }
    }

    public void onE(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("E note has been hit");
            piano.PlayOneShot(Enote);
        }
    }

    public void onF(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("F note has been hit");
            piano.PlayOneShot(Fnote);
        }
    }

    public void onFSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("F# note has been hit");
            piano.PlayOneShot(FSnote);
        }
    }

    public void onG(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("G note has been hit");
            piano.PlayOneShot(Gnote);
        }
    }

    public void onGSharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("G# note has been hit");
            piano.PlayOneShot(GSnote);
        }
    }

    public void onA(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("A note has been hit");
            piano.PlayOneShot(Anote);
        }
    }

    public void onASharp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("A# note has been hit");
            piano.PlayOneShot(ASnote);
        }
    }

    public void onB(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("B note has been hit");
            piano.PlayOneShot(Bnote);
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

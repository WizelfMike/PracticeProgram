using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PianoInputs : MonoBehaviour
{
    public PianoFull cpiano;

    public AudioSource Piano;
    public AudioClip C1;
    public AudioClip CS1;
    public AudioClip D1;
    public AudioClip DS1;
    public AudioClip E1;
    public AudioClip F1;
    public AudioClip FS1;
    public AudioClip G1;
    public AudioClip GS1;
    public AudioClip A1;
    public AudioClip AS1;
    public AudioClip B1;
    public AudioClip C2;
    public AudioClip CS2;
    public AudioClip D2;
    public AudioClip DS2;
    public AudioClip E2;
    public AudioClip F2;
    public AudioClip FS2;
    public AudioClip G2;
    public AudioClip GS2;
    public AudioClip A2;
    public AudioClip AS2;
    public AudioClip B2;
    public AudioClip C3;
    public AudioClip CS3;
    public AudioClip D3;
    public AudioClip DS3;
    public AudioClip E3;
    public AudioClip F3;
    public AudioClip FS3;
    public AudioClip G3;
    public AudioClip GS3;
    public AudioClip A3;
    public AudioClip AS3;
    public AudioClip B3;

    private void Awake()
    {
        cpiano = new PianoFull();
        cpiano.Enable();
    }

    public void onC1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(C1);
        }
    }

    public void onCS1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(CS1);
        }
    }

    public void onD1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(D1);
        }
    }

    public void onDS1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(DS1);
        }
    }

    public void onE1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(E1);
        }
    }

    public void onF1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(F1);
        }
    }

    public void onFS1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(FS1);
        }
    }

    public void onG1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(G1);
        }
    }

    public void onGS1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(GS1);
        }
    }

    public void onA1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(A1);
        }
    }

    public void onAS1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(AS1);
        }
    }

    public void onB1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(B1);
        }
    }

    public void onC2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(C2);
        }
    }

    public void onCS2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(CS2);
        }
    }

    public void onD2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(D2);
        }
    }

    public void onDS2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(DS2);
        }
    }

    public void onE2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(E2);
        }
    }

    public void onF2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(F2);
        }
    }

    public void onFS2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(FS2);
        }
    }

    public void onG2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(G2);
        }
    }

    public void onGS2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(GS2);
        }
    }

    public void onA2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(A2);
        }
    }

    public void onAS2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(AS2);
        }
    }

    public void onB2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(B2);
        }
    }

    public void onC3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(C3);
        }
    }

    public void onCS3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(CS3);
        }
    }

    public void onD3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(D3);
        }
    }

    public void onDS3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(DS3);
        }
    }

    public void onE3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(E3);
        }
    }

    public void onF3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(F3);
        }
    }

    public void onFS3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(FS3);
        }
    }

    public void onG3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(G3);
        }
    }

    public void onGS3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(GS3);
        }
    }

    public void onA3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(A3);
        }
    }

    public void onAS3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(AS3);
        }
    }

    public void onB3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Piano.PlayOneShot(B3);
        }
    }
}

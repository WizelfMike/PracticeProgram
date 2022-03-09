using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveMidi : MonoBehaviour
{
    bool pressed;
    public Vector3 place;

    void onPress(InputValue value)
    {
        pressed = value.isPressed;
    }
    
    void OnTrigger()
    {
        if (pressed)
        {
            gameObject.transform.Rotate(new Vector3(0, 5, 0));
            Debug.Log("Rotate");
        }
        else
        {
            return;
        }
    }

    private void Update()
    {
        OnTrigger();
    }
}

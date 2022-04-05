using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FreePlayScript : MonoBehaviour
{
    public TextMeshProUGUI keyText;

    public float onScreenTimer = 1;
    void Start()
    {
        
    }

    private void Update()
    {
        onScreenTimer -= Time.deltaTime;
        if (onScreenTimer <= 0)
        {
            keyText.SetText(" ");
        }
    }

    public void PlayKey(string keyInput)
    {
        onScreenTimer = 1;
        keyText.SetText(keyInput);
    }
}

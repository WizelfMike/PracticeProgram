using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FreePlayScript : MonoBehaviour
{
    public TextMeshProUGUI keyText;

    public void PlayKey(string keyInput)
    {
        keyText.SetText(keyInput);
    }
}

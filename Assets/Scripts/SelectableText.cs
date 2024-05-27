using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectableText : MonoBehaviour
{
    public TextMeshProUGUI lookpercentText;
    public float lookpercent;

    private void Update()
    {
        lookpercentText.text = lookpercent.ToString("F3"); 
    }
}

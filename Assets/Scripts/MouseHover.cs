using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseHover : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshPro>().color = Color.yellow;
        
    }

    void OnMouseEnter()
    {
        GetComponent<TextMeshPro>().color = Color.white;
        GetComponent<TextMeshPro>().fontSize = 40;
    }

    void OnMouseExit() 
    {
        GetComponent<TextMeshPro>().color = Color.yellow;
        GetComponent<TextMeshPro>().fontSize = 36;
    }
}

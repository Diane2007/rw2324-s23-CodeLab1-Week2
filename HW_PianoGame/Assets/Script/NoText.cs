using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NoText : MonoBehaviour
{
    //init text
    TextMeshProUGUI correctText;

    void Start()
    {
        //find the text
        correctText = GameObject.FindGameObjectWithTag("Correct").GetComponent<TextMeshProUGUI>();
        
        //don't show the text in the end scene please
        correctText.gameObject.SetActive(false);
    }
}

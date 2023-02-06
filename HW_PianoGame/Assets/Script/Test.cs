using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Test : MonoBehaviour
{
    //point to the audio source
    //Level 1: C4
    //Level 2: E
    //Level 3: G
    public AudioSource pianoNote;

    //init the text
    TextMeshProUGUI correctText;
    
    //point to the new public variable (set to C4 because we only want to check if C4 is clicked)
    public ClickPlay answer;
    
    //checking if the test audio is done playing
    public static bool donePlaying;

    //a small timer
    float time;
    
    void Start()
    {
        //find the text
        correctText = GameObject.FindGameObjectWithTag("Correct").GetComponent<TextMeshProUGUI>();
        
        //the "correct" text doesn't show in the beginning
        correctText.gameObject.SetActive(false);
        
        //default false
        donePlaying = false;
        
        //start test
        StartCoroutine(PlayTestAudio());
    }

    IEnumerator PlayTestAudio()
    {
        //after start, wait for 2 seconds before starting to play audio
        pianoNote.PlayDelayed(2);

        //wait for another 2 seconds
        yield return new WaitForSeconds(2);
        
        //check test bool
        donePlaying = true;
    }

    void Update()
    {
        //if C4 is checked
        if (answer.clicked == true)
        {
            time += Time.deltaTime;
            correctText.gameObject.SetActive(true);

            //make sure it doesn't change scene before
            //3 second limit is up
            if (time >= 3f)
            { 
                //set the bool of checking correct answer to true
                GameManager.rightAnswer = true;
                
                //find the object
                //so it goes on to the next scene as child of the singleton
                correctText = GameObject.FindGameObjectWithTag("Correct").GetComponent<TextMeshProUGUI>();
                // correctText.gameObject.SetActive(false);
            }
        }
    }
}

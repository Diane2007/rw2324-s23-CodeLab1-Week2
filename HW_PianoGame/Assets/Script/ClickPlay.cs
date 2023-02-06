using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPlay : MonoBehaviour
{
    //point to the audio
    public AudioSource pianoNote;
    
    //check if any piano key is clicked
    //remember to set the key(s) in inspector!!
    public bool clicked;
    
    //point to Level1Test script

    //creating a button situation
    //because text mesh pro sucks
    private void OnMouseOver()
    {
        //only when the test audio is played
        //can the player start playing the piano
        
        
        //when clicking the left button on mouse
        if (Input.GetMouseButtonDown(0) && Test.donePlaying == true)
        {
            //plays the piano note
            pianoNote.Play();
            clicked = true;
        }
    }


}

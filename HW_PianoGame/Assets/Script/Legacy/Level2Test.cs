using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Test : MonoBehaviour
{
    public static bool lv2DonePlaying;
    
    public AudioClip[] test2;
    AudioSource cMajor;
    
    void Start()
    {
        //default false
        lv2DonePlaying = false;

        StartCoroutine(PlayTestAudio());
        
        //set cMajor to the audio source
        cMajor = GetComponent<AudioSource>();
    }
    
    IEnumerator PlayTestAudio()
    {
        //a for loop
        //starting with the first index of the array
        //till the last index of the array
        //i++ means it goes up 1 every time
        for (int i = 0; i < test2.Length; i++)
        {
            //only play once, all together
            //start by  i = 0
            cMajor.PlayOneShot(test2[i]);
        }
        //wait for another 2 seconds to play lv2 test audio
        yield return new WaitForSeconds(2);
        
        //done playing the test audio and change the bool to true
        lv2DonePlaying = true;
    }
}

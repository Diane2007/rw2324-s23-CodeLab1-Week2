using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPiano : MonoBehaviour
{
    //set a singleton for the piano
    public static KeepPiano Instance;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
}

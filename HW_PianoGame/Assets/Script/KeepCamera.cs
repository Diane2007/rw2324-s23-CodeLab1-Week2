using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCamera : MonoBehaviour
{
    //keep the same camera
    //so it doesn't change the distance...
    //and make my life easier

    public static KeepCamera Instance;

    void Awake()
    {
        if (!Instance)
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

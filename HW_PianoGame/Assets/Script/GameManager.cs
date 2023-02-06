using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //init a singleton
    public static GameManager Instance;
    
    //bool to check if a correct key is pressed
    public static bool rightAnswer = false;

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

    void LateUpdate()
    {
        //if the correct key(s) is pressed
        //go to the next scene
        if (rightAnswer == true)
        {
            //make sure the total scene count is 4
            if (SceneManager.GetActiveScene().buildIndex < 4)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                rightAnswer = false; //just so it doesn't keep going to the next scene
            }

        }
        
    }
    
}

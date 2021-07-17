using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance; // Define an instance of the GameManager
    public static GameManager Instance // Allow other classes to communicate with the GameManager. 
    {
        get 
        {
            if (_instance == null) // Check if the GameManager exists.
                Debug.Log("Game Manager is NULL");
            
            return _instance; 
        }
    }

    private void Awake()
    {
        _instance = this; // Initialize the singleton
    }

    public void DisplayName()
    {
        Debug.Log("My name is Xavier.");
    }
}


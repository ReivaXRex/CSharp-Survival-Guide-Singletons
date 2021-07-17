using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance; // private variable to declare the instance of this class -- has to be static!
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log("UI Manager is NULL");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void UpdateScore(int score)
    { 
    
    }
}

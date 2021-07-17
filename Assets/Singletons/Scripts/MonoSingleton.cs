using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    // Act as a generic template for singletons.

    private static T _instance;
    public static T Instance
    {
        get 
        {
            if (_instance == null)
                Debug.Log(typeof(T).ToString() + " is NULL.");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this as T;
    }

}

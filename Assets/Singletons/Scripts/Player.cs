using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    // private GameManager _gm;

    void Start()
    {
        GameManager.Instance.DisplayName();
        UIManager.Instance.UpdateScore(40);
        SpawnManager.Instance.SpawnEnemy();
        // _gm = GameObject.Find("Game_Manager").GetComponent<GameManager>();
    }
}

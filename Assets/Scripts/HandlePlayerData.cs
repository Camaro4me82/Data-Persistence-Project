using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayerData : MonoBehaviour
{
    //Static Class for save the current player data;
    //Singleton pattern

    public static HandlePlayerData Instance;

    public string PlayerName;

    public int Score;

    private void Awake()
    {
        //Null exception set to prevent any unwanted errors.
       
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}


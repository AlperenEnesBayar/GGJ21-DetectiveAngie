using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton Player Class
public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    public int current_level = 0;
    public List<bool> Levels;
    public List<string> Killers;
    public List<string> Features;
    public string choosen;
    public bool isDone = false;
    public bool isWin = false;
    public bool isMissed = false;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Instance will not be destroyed between scenes 
        }
        else
        {
            Destroy(gameObject); // It will save only first instance. 
        }
    }

}

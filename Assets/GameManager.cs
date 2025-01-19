using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int currentLevel = -1;
    public bool allplaced = false;
    public int currentleft = 0;
    public bool pause = false;

    void Awake()
    {
        // Ensures only one instance of GameManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keeps the object between scene loads
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

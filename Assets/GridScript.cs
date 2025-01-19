using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{
    public int[] lvlPlaceables = {4,4,8};
    int totalplaced = 0;
    int currentLvl = -1;
    bool allplaced = false;
    //find which level
    

    void Update () 
    {
        if (GameManager.Instance != null)
        {
            currentLvl = GameManager.Instance.currentLevel;
            allplaced = GameManager.Instance.allplaced;
        }


        GameObject[] WR = GameObject.FindGameObjectsWithTag("WR");
        GameObject[] WL = GameObject.FindGameObjectsWithTag("WL");

        totalplaced = WR.Length + WL.Length;
        GameManager.Instance.currentleft = lvlPlaceables[currentLvl] - totalplaced;

        if (totalplaced == lvlPlaceables[currentLvl])
        {
            GameManager.Instance.allplaced = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void startlvl1()
    {
        SceneManager.LoadScene("LevelTwo");
        GameManager.Instance.currentLevel = 0; 
    }
    public void startlvl2() {
        SceneManager.LoadScene("LevelThree");
        GameManager.Instance.currentLevel = 1;  
    }
    public void startlvl3() {
        SceneManager.LoadScene("LevelFour");
        GameManager.Instance.currentLevel = 2;
    }
}

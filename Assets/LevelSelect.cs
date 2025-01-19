using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void startlvl1()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    public void startlvl2() {
        SceneManager.LoadScene("LevelThree");
    }
    public void startlvl3() {
        SceneManager.LoadScene("LevelFour");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartlvlSelect()
    {
        SceneManager.LoadScene("LevelSelect");
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
}

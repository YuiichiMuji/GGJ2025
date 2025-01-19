using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    SoundManager sound;
    public void StartlvlSelect()
    {
        SceneManager.LoadScene("LevelSelect");
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Start()
    {
        sound = GameObject.FindWithTag("sound").GetComponent<SoundManager>();
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorialscene");
    }
}

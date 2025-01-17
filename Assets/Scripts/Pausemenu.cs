using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        GameManager.Instance.pause = true;
    }
    public void resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        GameManager.Instance.pause = false;
    }
    public void quit()
    {
        SceneManager.LoadScene("Start Screen");
    }
}

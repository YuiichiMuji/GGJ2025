using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    private bool pauseCheck = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
        }
    }

    private void Pause()
    {

    }

    public void Lost()
    {

    }

    public void Win()
    {

    }
}

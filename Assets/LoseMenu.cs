using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public GameObject loseMenu;
    private bool launch = false;
    SoundManager sound;
    // Start is called before the first frame update
    void Start()
    {
        loseMenu.SetActive(false);
        sound = GameObject.FindWithTag("sound").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameObject.FindWithTag("Bubble") == null) && (launch == true))
        {
            sound.PlaySound(sound.break_);
            lose();
        }
    }

    public void lose()
    {
        loseMenu.SetActive(true);
        Time.timeScale = 0f;
        sound.PlaySound(sound.fail_1);
    }
    public void launched()
    {
        launch = true;
    }
    public void quit()
    {
        loseMenu.SetActive(false);
        SceneManager.LoadScene("Start Screen");
    }
}

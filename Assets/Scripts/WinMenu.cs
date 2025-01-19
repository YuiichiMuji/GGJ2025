using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenu;
    public Finish finish;
    SoundManager sound;
    // Start is called before the first frame update
    void Start()
    {
        winMenu.SetActive(false);
        finish = FindObjectOfType<Finish>();
        sound = GameObject.FindWithTag("sound").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (finish.win == true)
        {
            won();
        }
    }

    public void won()
    {
        Time.timeScale = 0f;
        winMenu.SetActive(true);
        sound.PlaySound(sound.Win);
    }
    public void quitMenu()
    {
        winMenu.SetActive(false);
        SceneManager.LoadScene("Start Screen");
    }
}

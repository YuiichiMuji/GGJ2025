using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject finish;
    public script s = finish.GetComponent<Finish>();
    // Start is called before the first frame update
    void Start()
    {
        winMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (finish.win)
        {
            won();
        }
    }

    public void won()
    {
        Time.timeScale = 0f;
        winMenu.SetActive(true);
    }
    public void quitMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }
    public void quit()
    {
        Debug.Log("Quit");
    }
}

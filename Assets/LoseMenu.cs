using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public GameObject loseMenu;
    private bool launch = false;

    // Start is called before the first frame update
    void Start()
    {
        loseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameObject.FindWithTag("Bubble") == null) && (launch == true))
        {
            lose();
        }
    }

    public void lose()
    {
        loseMenu.SetActive(true);
    }
    public void launched()
    {
        launch = true;
    }
}

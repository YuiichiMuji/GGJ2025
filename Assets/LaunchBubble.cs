using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBubble : MonoBehaviour
{
    public Shooter shooter;
    public LoseMenu loseMenu;
    public void Launch()
    {
        shooter.Launch();
        loseMenu.launched();
    }
}

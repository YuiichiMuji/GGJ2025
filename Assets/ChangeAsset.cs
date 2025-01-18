using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAsset : MonoBehaviour
{
    public BuildManager Buildm;
    public int SelectedWall = 0;
    public void switchRight()
    {
        SelectedWall = 0;
    }
    public void switchLeft()
    {
        SelectedWall = 1;
    }
    void Update()
    {
        Buildm.SelectedWall(SelectedWall);
    }
}

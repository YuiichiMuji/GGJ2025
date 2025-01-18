using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;

    [Header("References")]
    [SerializeField] private GameObject[] wallPrefabs;

    public int selectedWall = 0;

    public void Awake()
    {
        main = this;
    }

    public void SelectedWall(int wall)
    {
        selectedWall = wall;
    }

    public GameObject getSelectedWall()
    {
        return wallPrefabs[selectedWall];
    }
}

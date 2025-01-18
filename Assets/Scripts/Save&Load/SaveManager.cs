//使用UTF-8
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager
{
    public static SaveManager Instance;

    public List<bool> levelStatusList;

    public void SetLevelSuccess(int levelIndex)
    {

    }

    private void Init()
    {
        Instance = this;


    }
}

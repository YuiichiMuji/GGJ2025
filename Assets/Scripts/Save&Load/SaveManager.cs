//使用UTF-8
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager
{
    public static int LevelCount;
    private static SaveManager instance;

    public static SaveManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SaveManager();
            }
            return instance;
        }
    }

    public List<int> levelStatusList;

    /// <summary>
    /// 设置关卡完成
    /// </summary>
    /// <param name="levelIndex"></param>
    public void SetLevelSuccess(int levelIndex)
    {
        PlayerPrefs.SetInt($"success_level_{levelIndex}", 1);
    }

    /// <summary>
    /// 获取关卡情况
    /// </summary>
    /// <param name="levelIndex"></param>
    /// <returns>true-完成，false-未完成</returns>
    public bool GetLevelStatus(int levelIndex)
    {
        var resultValue = PlayerPrefs.GetInt($"success_level_{levelIndex}", 0);
        return resultValue != 0;
    }

    public SaveManager()
    {
        levelStatusList = new List<int>();
        for (int i = 0; i < LevelCount; i++)
        {
            levelStatusList.Add(PlayerPrefs.GetInt($"success_level_{i}", 0));
        }
    }
}

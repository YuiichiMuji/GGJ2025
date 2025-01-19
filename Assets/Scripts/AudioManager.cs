using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip winningAll;
    public AudioSource efxAS;
    public static AudioManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            GameObject.Destroy(gameObject);
        }
    }

    /// <summary>
    /// 全部通关时播放
    /// </summary>
    public void OnWinningAllLevels()
    {
        efxAS.PlayOneShot(winningAll);
    }
}

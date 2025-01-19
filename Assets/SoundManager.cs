using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource sound;

    public AudioClip fail_1 , fail_2 , Win, break_ , output , click_1 , click_2;

    public void Start()
    {
        
    }

    public void PlaySound(AudioClip clip)
    {
        sound.PlayOneShot(clip);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaySound(click_1);
        }
    }
}

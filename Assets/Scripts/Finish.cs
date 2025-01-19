using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public bool win = false;
    SoundManager sound;
    void start()
    {
        sound = GameObject.FindWithTag("sound").GetComponent<SoundManager>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            win = true;
            sound.PlaySound(sound.Win);
        }
    }
}

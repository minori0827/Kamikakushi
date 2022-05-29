using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    public AudioManager audioManager;
    
    void Start()
    {
        audioManager.PlayBGM(0);
    }
}

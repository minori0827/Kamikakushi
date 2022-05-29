using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] bgm;
    public AudioClip[] se;
    
    [SerializeField]
    [Range(0, 1)]
    float bgmVolume = 1.0f;
    [SerializeField]
    [Range(0, 1)]
    float seVolume = 1.0f;
    
    AudioSource bgmAudioSource;
    AudioSource seAudioSource;
    
    void Awake()
    {
        bgmAudioSource = gameObject.AddComponent<AudioSource>();
        seAudioSource = gameObject.AddComponent<AudioSource>();
    }
    
    public void PlayBGM(int num)
    {
        if(num >= 0)
        {
            bgmAudioSource.clip = bgm[num];
            bgmAudioSource.loop = true;
            if (num == 0)
            {
                bgmAudioSource.volume = bgmVolume;
            }
            else if (num == 1)
            {
                bgmAudioSource.volume = bgmVolume * 0.4f;
            }
            else if (num == 2)
            {
                bgmAudioSource.volume = bgmVolume * 0.8f;
            }
            else if (num == 3)
            {
                bgmAudioSource.volume = bgmVolume;
            }
            bgmAudioSource.Play();
        }
        else
        {
            bgmAudioSource.Stop();
        }
    }
    
    public void PlaySE(int num)
    {
        seAudioSource.PlayOneShot(se[num], seVolume);
    }
}

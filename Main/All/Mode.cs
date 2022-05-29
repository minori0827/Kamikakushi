using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{
    public static Mode instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public int mode = 0;
    // 0 小前 1 猫田 2 二人
    public GameObject talk;
    
    public void Omae()
    {
        mode = 0;
        talk.SetActive(false);
    }
    public void Nekoda()
    {
        mode = 1;
        talk.SetActive(false);
    }
    public void Hutari()
    {
        mode = 2;
        talk.SetActive(true);
    }
}

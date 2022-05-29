using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscBox2 : MonoBehaviour
{
    public List<Disc> discList = new List<Disc>();
    public List<Button> buttonList = new List<Button>();
    public GameObject coverLeft;
    public GameObject coverRight;
    public GameObject discCamera;
    public bool clear;
    public AudioManager audioManager;
    
    private int count = 0;
    
    public void ClearCheck()
    {
        count = 0;
        foreach (Disc disc in discList)
        {
            var bar = disc.currentBar;
            if (bar != 0)
            {
                break;
            }
            count ++;
        }
        if (count == discList.Count)
        {
            Clear();
        }
    }
    
    public void Clear()
    {
        foreach (Button button in buttonList)
        {
            button.GetComponent<Button>().enabled = false;
            button.GetComponent<Collider>().enabled = false;
        }
        audioManager.PlaySE(0);
        Invoke("CameraBack",1f);
        Invoke("Open",2f);
        Invoke("PlaySE",2f);
        clear = true;
    }
    
    public void CameraBack()
    {
        this.GetComponent<Collider>().enabled = false;
    }
    
    public void Open()
    {
        coverLeft.transform.localPosition = new Vector3(-2.0f,0,0);
        coverLeft.transform.localRotation = Quaternion.Euler(0,200,90);
        coverRight.transform.localPosition = new Vector3(0.8f,0,-23.8f);
        coverRight.transform.localRotation = Quaternion.Euler(0,160,90);
        this.GetComponent<Collider>().enabled = false;
    }
    
    public void PlaySE()
    {
        audioManager.PlaySE(2);
    }
    
    public void SetStart()
    {
        Open();
        foreach (Disc disc in discList)
        {
            disc.currentBar = 0;
            disc.DiscRotation();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscBox : MonoBehaviour
{
    public List<Disc> discList = new List<Disc>();
    public List<Button> buttonList = new List<Button>();
    public GameObject cover;
    public GameObject discCamera;
    public GameObject box;
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
        Invoke("CameraBack",1f);
        Invoke("Open",2f);
        Invoke("PlaySE",2f);
        audioManager.PlaySE(0);
    }
    
    public void CameraBack()
    {
        discCamera.GetComponent<SubCamera2>().OnBackArrow2();
        this.GetComponent<Collider>().enabled = false;
    }
    
    public void Open()
    {
        cover.transform.localRotation = Quaternion.Euler(0,0,135);
        this.GetComponent<Collider>().enabled = false;
        box.GetComponent<Collider>().enabled = false;
        clear = true;
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
    
    public void PlaySE()
    {
        audioManager.PlaySE(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasChanger : MonoBehaviour
{
    public GameObject menuCanvas;
    public GameObject searchCanvas;
    
    public void CanvasChange()
    {
        if(menuCanvas.activeSelf == true)
        {
            menuCanvas.SetActive(false);
            searchCanvas.SetActive(true);
        }
        else
        {
            menuCanvas.SetActive(true);
            searchCanvas.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintCanvas : MonoBehaviour
{
    public GameObject hintCanvas;
    
    public void Open()
    {
        hintCanvas.SetActive(true);
    }
    
    public void CanvasClose()
    {
        hintCanvas.SetActive(false);
    }
}

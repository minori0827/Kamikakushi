using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvas : MonoBehaviour
{
    public GameObject endCanvas;
    
    public void CanvasOn()
    {
        endCanvas.SetActive(true);
    }
    
    public void CanvasOff()
    {
        endCanvas.SetActive(false);
    }
}
